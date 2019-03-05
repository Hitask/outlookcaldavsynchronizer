﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalDavSynchronizer.Ui.ConnectionTests;

namespace CalDavSynchronizer.Utilities
{
    /// <summary>
    /// Ref https://stackoverflow.com/questions/1600962/displaying-the-build-date
    /// </summary>
    public static class BuildDateTime
    {      
        public struct _IMAGE_FILE_HEADER
        {
            public ushort Machine;
            public ushort NumberOfSections;
            public uint TimeDateStamp;
            public uint PointerToSymbolTable;
            public uint NumberOfSymbols;
            public ushort SizeOfOptionalHeader;
            public ushort Characteristics;
        };
        public static DateTime GetBuildDateTime(this Assembly assembly)
        {
            var codeBase = assembly?.GetName()?.CodeBase;
            if (codeBase != null)
            {
                UriBuilder uri = new UriBuilder(codeBase);
                var uriCode = Uri.UnescapeDataString(uri.Path);
                string path = Path.GetFullPath(uriCode);
                if (File.Exists(path))
                {
                    var buffer = new byte[Math.Max(Marshal.SizeOf(typeof(_IMAGE_FILE_HEADER)), 4)];
                    using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        fileStream.Position = 0x3C;
                        fileStream.Read(buffer, 0, 4);
                        fileStream.Position = BitConverter.ToUInt32(buffer, 0); // COFF header offset
                        fileStream.Read(buffer, 0, 4); // "PE\0\0"
                        fileStream.Read(buffer, 0, buffer.Length);
                    }
                    var pinnedBuffer = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                    try
                    {
                        var coffHeader = (_IMAGE_FILE_HEADER)Marshal.PtrToStructure(pinnedBuffer.AddrOfPinnedObject(), typeof(_IMAGE_FILE_HEADER));

                        return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1) + new TimeSpan(coffHeader.TimeDateStamp * TimeSpan.TicksPerSecond));
                    }
                    finally
                    {
                        pinnedBuffer.Free();
                    }
                }
            }
            return new DateTime();
        }

        public static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null)
        {
            var filePath = assembly.Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;

            var buffer = new byte[2048];

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                stream.Read(buffer, 0, 2048);

            var offset = BitConverter.ToInt32(buffer, c_PeHeaderOffset);
            var secondsSince1970 = BitConverter.ToInt32(buffer, offset + c_LinkerTimestampOffset);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var linkTimeUtc = epoch.AddSeconds(secondsSince1970);

            var tz = target ?? TimeZoneInfo.Local;
            var localTime = TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, tz);

            return localTime;
        }
    }
}