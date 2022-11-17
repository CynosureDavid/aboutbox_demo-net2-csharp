using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AboutBoxDemo
{
    /// <summary>
    /// Generic About Box Dialog demo form
    /// </summary>
    /// <remarks>
    /// Jeff Atwood
    /// http://www.codinghorror.com
    /// </remarks>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAbout()
        {
            AboutBox ab = new AboutBox();
            ab.AppTitle = txtTitle.Text;
            ab.AppDescription = txtDescription.Text;
            ab.AppVersion = txtVersion.Text;
            ab.AppCopyright = txtCopyright.Text;
            ab.AppMoreInfo = txtMoreInfo.Text;
            ab.AppDetailsButton = chkDetails.Checked;
            ab.ShowDialog(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            txtTitle.Text = ab.AppTitle;
            txtDescription.Text = ab.AppDescription;
            txtVersion.Text = ab.AppVersion;
            txtCopyright.Text = ab.AppCopyright;
            txtMoreInfo.Text = ab.AppMoreInfo;

            txtMoreInfo.Text += Environment.NewLine;
            txtMoreInfo.Text += Environment.NewLine;
            txtMoreInfo.Text += "http://www.codinghorror.com/blog/" + Environment.NewLine;
            txtMoreInfo.Text += "mailto:jatwood@codinghorror.com?subject=your+code+stinks" + Environment.NewLine;

        }
    }
}