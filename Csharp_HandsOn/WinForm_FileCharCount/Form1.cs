using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_FileCharCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.ShowDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = await ReadFile(fileDialog.FileName);
                foreach (var item in text)
                {
                    count++;
                }
                label1.Text = "No of Characters in the file: " + count;
            }
        }

        public Task<string> ReadFile(string path)
        {
            return Task.FromResult(File.ReadAllText(path));
        }
    }
}