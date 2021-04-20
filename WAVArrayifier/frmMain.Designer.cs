namespace WAVArrayifier
{
    partial class frmMain
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
            this.gbFrom = new System.Windows.Forms.GroupBox();
            this.cboOutputType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSampleCount = new System.Windows.Forms.TextBox();
            this.cboInputType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputName = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmdLoadInput = new System.Windows.Forms.Button();
            this.gbTo = new System.Windows.Forms.GroupBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.gbFrom.SuspendLayout();
            this.gbTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFrom
            // 
            this.gbFrom.Controls.Add(this.cboOutputType);
            this.gbFrom.Controls.Add(this.label4);
            this.gbFrom.Controls.Add(this.label3);
            this.gbFrom.Controls.Add(this.txtSampleCount);
            this.gbFrom.Controls.Add(this.cboInputType);
            this.gbFrom.Controls.Add(this.label2);
            this.gbFrom.Controls.Add(this.label1);
            this.gbFrom.Controls.Add(this.txtOutputName);
            this.gbFrom.Controls.Add(this.txtInput);
            this.gbFrom.Controls.Add(this.cmdLoadInput);
            this.gbFrom.Location = new System.Drawing.Point(12, 12);
            this.gbFrom.Name = "gbFrom";
            this.gbFrom.Size = new System.Drawing.Size(460, 460);
            this.gbFrom.TabIndex = 0;
            this.gbFrom.TabStop = false;
            this.gbFrom.Text = "Convert From";
            // 
            // cboOutputType
            // 
            this.cboOutputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOutputType.FormattingEnabled = true;
            this.cboOutputType.Location = new System.Drawing.Point(287, 409);
            this.cboOutputType.Name = "cboOutputType";
            this.cboOutputType.Size = new System.Drawing.Size(167, 21);
            this.cboOutputType.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output Data Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sample Count";
            // 
            // txtSampleCount
            // 
            this.txtSampleCount.Location = new System.Drawing.Point(6, 430);
            this.txtSampleCount.MaxLength = 31;
            this.txtSampleCount.Name = "txtSampleCount";
            this.txtSampleCount.ReadOnly = true;
            this.txtSampleCount.Size = new System.Drawing.Size(99, 20);
            this.txtSampleCount.TabIndex = 8;
            // 
            // cboInputType
            // 
            this.cboInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInputType.FormattingEnabled = true;
            this.cboInputType.Location = new System.Drawing.Point(287, 382);
            this.cboInputType.Name = "cboInputType";
            this.cboInputType.Size = new System.Drawing.Size(167, 21);
            this.cboInputType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Array Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Data Type";
            // 
            // txtOutputName
            // 
            this.txtOutputName.Location = new System.Drawing.Point(287, 434);
            this.txtOutputName.MaxLength = 31;
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.Size = new System.Drawing.Size(167, 20);
            this.txtOutputName.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 19);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(448, 355);
            this.txtInput.TabIndex = 1;
            // 
            // cmdLoadInput
            // 
            this.cmdLoadInput.Location = new System.Drawing.Point(6, 380);
            this.cmdLoadInput.Name = "cmdLoadInput";
            this.cmdLoadInput.Size = new System.Drawing.Size(99, 23);
            this.cmdLoadInput.TabIndex = 0;
            this.cmdLoadInput.Text = "Load";
            this.cmdLoadInput.UseVisualStyleBackColor = true;
            this.cmdLoadInput.Click += new System.EventHandler(this.CmdLoadInput_Click);
            // 
            // gbTo
            // 
            this.gbTo.Controls.Add(this.cmdSave);
            this.gbTo.Controls.Add(this.txtOutput);
            this.gbTo.Enabled = false;
            this.gbTo.Location = new System.Drawing.Point(569, 12);
            this.gbTo.Name = "gbTo";
            this.gbTo.Size = new System.Drawing.Size(460, 460);
            this.gbTo.TabIndex = 1;
            this.gbTo.TabStop = false;
            this.gbTo.Text = "Convert To";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(379, 380);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(448, 355);
            this.txtOutput.TabIndex = 2;
            // 
            // cmdConvert
            // 
            this.cmdConvert.Enabled = false;
            this.cmdConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmdConvert.Location = new System.Drawing.Point(478, 12);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(85, 431);
            this.cmdConvert.TabIndex = 2;
            this.cmdConvert.Text = ">";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.CmdConvert_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Enabled = false;
            this.cmdReset.Location = new System.Drawing.Point(478, 449);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(85, 23);
            this.cmdReset.TabIndex = 8;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 484);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.gbTo);
            this.Controls.Add(this.gbFrom);
            this.Name = "frmMain";
            this.Text = "WAVArrayifier";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbFrom.ResumeLayout(false);
            this.gbFrom.PerformLayout();
            this.gbTo.ResumeLayout(false);
            this.gbTo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFrom;
        private System.Windows.Forms.ComboBox cboInputType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutputName;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button cmdLoadInput;
        private System.Windows.Forms.GroupBox gbTo;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSampleCount;
        private System.Windows.Forms.ComboBox cboOutputType;
        private System.Windows.Forms.Label label4;
    }
}

