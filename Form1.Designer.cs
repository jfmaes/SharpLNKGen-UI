namespace LnkGen_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTargetBrowser = new System.Windows.Forms.Button();
            this.BtnIconBrowser = new System.Windows.Forms.Button();
            this.chkArguments = new System.Windows.Forms.CheckBox();
            this.chkDescription = new System.Windows.Forms.CheckBox();
            this.txtArgs = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.chkBamboozle = new System.Windows.Forms.CheckBox();
            this.chkExpertMode = new System.Windows.Forms.CheckBox();
            this.txtADFS = new System.Windows.Forms.TextBox();
            this.btnADFS = new System.Windows.Forms.Button();
            this.lblADFS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboADFStreams = new System.Windows.Forms.ComboBox();
            this.gpbxExpert = new System.Windows.Forms.GroupBox();
            this.txtADSName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddADFS = new System.Windows.Forms.Button();
            this.btnCheckADFS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.gpbxExpert.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Icon";
            // 
            // BtnTargetBrowser
            // 
            this.BtnTargetBrowser.Location = new System.Drawing.Point(395, 19);
            this.BtnTargetBrowser.Name = "BtnTargetBrowser";
            this.BtnTargetBrowser.Size = new System.Drawing.Size(64, 20);
            this.BtnTargetBrowser.TabIndex = 3;
            this.BtnTargetBrowser.Text = "Browse...";
            this.BtnTargetBrowser.UseVisualStyleBackColor = true;
            this.BtnTargetBrowser.Click += new System.EventHandler(this.BtnTargetBrowser_Click);
            // 
            // BtnIconBrowser
            // 
            this.BtnIconBrowser.Location = new System.Drawing.Point(395, 45);
            this.BtnIconBrowser.Name = "BtnIconBrowser";
            this.BtnIconBrowser.Size = new System.Drawing.Size(64, 20);
            this.BtnIconBrowser.TabIndex = 4;
            this.BtnIconBrowser.Text = "Browse...";
            this.BtnIconBrowser.UseVisualStyleBackColor = true;
            this.BtnIconBrowser.Click += new System.EventHandler(this.BtnIconBrowser_Click);
            // 
            // chkArguments
            // 
            this.chkArguments.AutoSize = true;
            this.chkArguments.Location = new System.Drawing.Point(10, 86);
            this.chkArguments.Name = "chkArguments";
            this.chkArguments.Size = new System.Drawing.Size(76, 17);
            this.chkArguments.TabIndex = 5;
            this.chkArguments.Text = "Arguments";
            this.chkArguments.UseVisualStyleBackColor = true;
            this.chkArguments.Click += new System.EventHandler(this.chkArguments_Click);
            // 
            // chkDescription
            // 
            this.chkDescription.AutoSize = true;
            this.chkDescription.Location = new System.Drawing.Point(10, 119);
            this.chkDescription.Name = "chkDescription";
            this.chkDescription.Size = new System.Drawing.Size(79, 17);
            this.chkDescription.TabIndex = 6;
            this.chkDescription.Text = "Description";
            this.chkDescription.UseVisualStyleBackColor = true;
            this.chkDescription.Click += new System.EventHandler(this.chkDescription_Click);
            // 
            // txtArgs
            // 
            this.txtArgs.Location = new System.Drawing.Point(115, 81);
            this.txtArgs.Name = "txtArgs";
            this.txtArgs.Size = new System.Drawing.Size(271, 20);
            this.txtArgs.TabIndex = 7;
            this.txtArgs.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(115, 115);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(271, 20);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(192, 325);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 22);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(116, 19);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(271, 20);
            this.txtTarget.TabIndex = 10;
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(116, 46);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(271, 20);
            this.txtIcon.TabIndex = 11;
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(474, 19);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(48, 45);
            this.picbox.TabIndex = 12;
            this.picbox.TabStop = false;
            // 
            // chkBamboozle
            // 
            this.chkBamboozle.AutoSize = true;
            this.chkBamboozle.Location = new System.Drawing.Point(10, 153);
            this.chkBamboozle.Name = "chkBamboozle";
            this.chkBamboozle.Size = new System.Drawing.Size(188, 17);
            this.chkBamboozle.TabIndex = 13;
            this.chkBamboozle.Text = "Bamboozle (prepend whitespaces)";
            this.chkBamboozle.UseVisualStyleBackColor = true;
            // 
            // chkExpertMode
            // 
            this.chkExpertMode.AutoSize = true;
            this.chkExpertMode.Location = new System.Drawing.Point(10, 174);
            this.chkExpertMode.Name = "chkExpertMode";
            this.chkExpertMode.Size = new System.Drawing.Size(276, 17);
            this.chkExpertMode.TabIndex = 14;
            this.chkExpertMode.Text = "Expert Mode (disable valid file checks + enable ADS)";
            this.chkExpertMode.UseVisualStyleBackColor = true;
            this.chkExpertMode.Click += new System.EventHandler(this.chkExpertMode_Click);
            // 
            // txtADFS
            // 
            this.txtADFS.Location = new System.Drawing.Point(93, 19);
            this.txtADFS.Name = "txtADFS";
            this.txtADFS.Size = new System.Drawing.Size(271, 20);
            this.txtADFS.TabIndex = 17;
            // 
            // btnADFS
            // 
            this.btnADFS.Location = new System.Drawing.Point(373, 19);
            this.btnADFS.Name = "btnADFS";
            this.btnADFS.Size = new System.Drawing.Size(64, 20);
            this.btnADFS.TabIndex = 16;
            this.btnADFS.Text = "Browse...";
            this.btnADFS.UseVisualStyleBackColor = true;
            this.btnADFS.Click += new System.EventHandler(this.btnADFS_Click);
            // 
            // lblADFS
            // 
            this.lblADFS.AutoSize = true;
            this.lblADFS.Location = new System.Drawing.Point(33, 26);
            this.lblADFS.Name = "lblADFS";
            this.lblADFS.Size = new System.Drawing.Size(29, 13);
            this.lblADFS.TabIndex = 15;
            this.lblADFS.Text = "ADS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ADS attached";
            // 
            // cboADFStreams
            // 
            this.cboADFStreams.Enabled = false;
            this.cboADFStreams.FormattingEnabled = true;
            this.cboADFStreams.Location = new System.Drawing.Point(93, 79);
            this.cboADFStreams.Name = "cboADFStreams";
            this.cboADFStreams.Size = new System.Drawing.Size(271, 21);
            this.cboADFStreams.TabIndex = 19;
            // 
            // gpbxExpert
            // 
            this.gpbxExpert.Controls.Add(this.txtADSName);
            this.gpbxExpert.Controls.Add(this.label4);
            this.gpbxExpert.Controls.Add(this.btnAddADFS);
            this.gpbxExpert.Controls.Add(this.txtADFS);
            this.gpbxExpert.Controls.Add(this.cboADFStreams);
            this.gpbxExpert.Controls.Add(this.label3);
            this.gpbxExpert.Controls.Add(this.lblADFS);
            this.gpbxExpert.Controls.Add(this.btnADFS);
            this.gpbxExpert.Location = new System.Drawing.Point(10, 196);
            this.gpbxExpert.Name = "gpbxExpert";
            this.gpbxExpert.Size = new System.Drawing.Size(512, 123);
            this.gpbxExpert.TabIndex = 20;
            this.gpbxExpert.TabStop = false;
            this.gpbxExpert.Visible = false;
            // 
            // txtADSName
            // 
            this.txtADSName.Location = new System.Drawing.Point(93, 46);
            this.txtADSName.Name = "txtADSName";
            this.txtADSName.Size = new System.Drawing.Size(271, 20);
            this.txtADSName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ADS Name";
            // 
            // btnAddADFS
            // 
            this.btnAddADFS.Location = new System.Drawing.Point(373, 45);
            this.btnAddADFS.Name = "btnAddADFS";
            this.btnAddADFS.Size = new System.Drawing.Size(64, 20);
            this.btnAddADFS.TabIndex = 20;
            this.btnAddADFS.Text = "Add";
            this.btnAddADFS.UseVisualStyleBackColor = true;
            this.btnAddADFS.Click += new System.EventHandler(this.btnAddADFS_Click);
            // 
            // btnCheckADFS
            // 
            this.btnCheckADFS.Location = new System.Drawing.Point(192, 358);
            this.btnCheckADFS.Name = "btnCheckADFS";
            this.btnCheckADFS.Size = new System.Drawing.Size(121, 20);
            this.btnCheckADFS.TabIndex = 21;
            this.btnCheckADFS.Text = "Check ADS ";
            this.btnCheckADFS.UseVisualStyleBackColor = true;
            this.btnCheckADFS.Visible = false;
            this.btnCheckADFS.Click += new System.EventHandler(this.btnCheckADFS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 390);
            this.Controls.Add(this.btnCheckADFS);
            this.Controls.Add(this.chkExpertMode);
            this.Controls.Add(this.chkBamboozle);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtArgs);
            this.Controls.Add(this.chkDescription);
            this.Controls.Add(this.chkArguments);
            this.Controls.Add(this.BtnIconBrowser);
            this.Controls.Add(this.BtnTargetBrowser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbxExpert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lnkgen by jfmaes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.gpbxExpert.ResumeLayout(false);
            this.gpbxExpert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnTargetBrowser;
        private System.Windows.Forms.Button BtnIconBrowser;
        private System.Windows.Forms.CheckBox chkArguments;
        private System.Windows.Forms.CheckBox chkDescription;
        private System.Windows.Forms.TextBox txtArgs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.CheckBox chkBamboozle;
        private System.Windows.Forms.CheckBox chkExpertMode;
        private System.Windows.Forms.TextBox txtADFS;
        private System.Windows.Forms.Button btnADFS;
        private System.Windows.Forms.Label lblADFS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboADFStreams;
        private System.Windows.Forms.GroupBox gpbxExpert;
        private System.Windows.Forms.Button btnCheckADFS;
        private System.Windows.Forms.Button btnAddADFS;
        private System.Windows.Forms.TextBox txtADSName;
        private System.Windows.Forms.Label label4;
    }
}

