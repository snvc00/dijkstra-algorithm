using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SEMALG_actividad04
{
    public partial class Notification : Form
    {
        public Notification(string message, bool addLinkLabel = false)
        {
            InitializeComponent();
            UpdateLabel(message);

            if (addLinkLabel)
                LinkLabel_Documentation.Visible = true;
        }

        public void UpdateLabel(string msg)
        {
            Label_Message.Text = msg;
            Label_Message.Location = new Point(this.Width / 2 - (Label_Message.Width / 2), Label_Message.Location.Y);
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabel_Documentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(@"../../../docs/");
            Process.Start("index.html");
            Directory.SetCurrentDirectory(path);
            this.Close();
        }
    }
}
