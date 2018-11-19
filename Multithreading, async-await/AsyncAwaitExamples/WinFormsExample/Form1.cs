using System;
using System.Windows.Forms;
using DownloadServiceLib;

namespace WinFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: make this method not to block the UI thread while I/O operation

            textBox2.Text = string.Empty;
            var address = textBox1.Text;

            var response = DownloadService.Download(address);

            textBox2.Text = response;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            var address = textBox1.Text;

            var response = DownloadService.Download(address);

            textBox2.Text = response;
        }
    }
}
