using CalDavSynchronizer.Globalization;

namespace CalDavSynchronizer.Ui
{
  partial class AddResourceForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResourceForm));
            this._resourceNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this._useRandomNameCheckBox = new System.Windows.Forms.CheckBox();
            this._resourceColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // _resourceNameTextBox
            // 
            this._resourceNameTextBox.Location = new System.Drawing.Point(129, 10);
            this._resourceNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._resourceNameTextBox.Name = "_resourceNameTextBox";
            this._resourceNameTextBox.Size = new System.Drawing.Size(210, 20);
            this._resourceNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resource Displayname";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(181, 106);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(262, 106);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // _useRandomNameCheckBox
            // 
            this._useRandomNameCheckBox.AutoSize = true;
            this._useRandomNameCheckBox.Checked = true;
            this._useRandomNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._useRandomNameCheckBox.Location = new System.Drawing.Point(11, 37);
            this._useRandomNameCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._useRandomNameCheckBox.Name = "_useRandomNameCheckBox";
            this._useRandomNameCheckBox.Size = new System.Drawing.Size(211, 17);
            this._useRandomNameCheckBox.TabIndex = 4;
            this._useRandomNameCheckBox.Text = "Use random string for DAV resource Uri";
            this._toolTip.SetToolTip(this._useRandomNameCheckBox, "If unchecked the displayname is used for creating the DAV resource Uri instead of" +
        " a random string.");
            this._useRandomNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // _resourceColorButton
            // 
            this._resourceColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._resourceColorButton.Location = new System.Drawing.Point(129, 59);
            this._resourceColorButton.Name = "_resourceColorButton";
            this._resourceColorButton.Size = new System.Drawing.Size(75, 23);
            this._resourceColorButton.TabIndex = 5;
            this._resourceColorButton.UseVisualStyleBackColor = true;
            this._resourceColorButton.Click += new System.EventHandler(this._resourceColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calendar Color";
            // 
            // _toolTip
            // 
            this._toolTip.AutoPopDelay = 30000;
            this._toolTip.InitialDelay = 500;
            this._toolTip.ReshowDelay = 100;
            // 
            // AddResourceForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(346, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._resourceColorButton);
            this.Controls.Add(this._useRandomNameCheckBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._resourceNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddResourceForm";
            this.Text = "Add Resource";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox _resourceNameTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.CheckBox _useRandomNameCheckBox;
    private System.Windows.Forms.Button _resourceColorButton;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ToolTip _toolTip;
  }
}