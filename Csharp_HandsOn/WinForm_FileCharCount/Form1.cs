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

        public async Task<string> ReadFile(string path)
        {
            await Task.Delay(5000);
            byte[] res;
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                res = new byte[fs.Length];
                await fs.ReadAsync(res, 0, (int)fs.Length);
            }
            return Encoding.ASCII.GetString(res);
        }
    }
}