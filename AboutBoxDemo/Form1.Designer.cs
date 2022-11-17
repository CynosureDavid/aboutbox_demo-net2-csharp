namespace AboutBoxDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label7 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtMoreInfo = new System.Windows.Forms.TextBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(12, 176);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 36);
            this.Label7.TabIndex = 29;
            this.Label7.Text = "(use ctrl+enter for newline)";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(284, 280);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(116, 23);
            this.Button1.TabIndex = 28;
            this.Button1.Text = "Show &About Box";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label6
            // 
            this.Label6.ForeColor = System.Drawing.Color.DarkRed;
            this.Label6.Location = new System.Drawing.Point(116, 32);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(288, 17);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "%strings% are obtained from AssemblyInfo file";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkDetails
            // 
            this.chkDetails.Checked = true;
            this.chkDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetails.Location = new System.Drawing.Point(116, 276);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(128, 24);
            this.chkDetails.TabIndex = 26;
            this.chkDetails.Text = "Show Details Button";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(12, 152);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 16);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "More Info";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(12, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 16);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Copyright";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(12, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 16);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Version";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 16);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Description";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 16);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Title";
            // 
            // txtMoreInfo
            // 
            this.txtMoreInfo.Location = new System.Drawing.Point(116, 148);
            this.txtMoreInfo.Multiline = true;
            this.txtMoreInfo.Name = "txtMoreInfo";
            this.txtMoreInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoreInfo.Size = new System.Drawing.Size(288, 124);
            this.txtMoreInfo.TabIndex = 20;
            this.txtMoreInfo.Text = "TextBox5";
            // 
            // txtCopyright
            // 
            this.txtCopyright.Location = new System.Drawing.Point(116, 124);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(236, 20);
            this.txtCopyright.TabIndex = 19;
            this.txtCopyright.Text = "TextBox4";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(116, 100);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(236, 20);
            this.txtVersion.TabIndex = 18;
            this.txtVersion.Text = "TextBox3";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(236, 20);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Text = "TextBox2";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(116, 52);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(236, 20);
            this.txtTitle.TabIndex = 16;
            this.txtTitle.Text = "TextBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.chkDetails);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtMoreInfo);
            this.Controls.Add(this.txtCopyright);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Box Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.CheckBox chkDetails;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtMoreInfo;
        internal System.Windows.Forms.TextBox txtCopyright;
        internal System.Windows.Forms.TextBox txtVersion;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

