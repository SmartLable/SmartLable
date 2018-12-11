using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 打开文件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "请打开一个文件";
            opd.Multiselect = true;
            opd.InitialDirectory = @"F:\PJ\杜帅0731\360手机助手Demo-14.2.6更新x2\360手机助手Demo-14.2.6更新x2\360Mobile";
            opd.Filter = "文本文件|*txt|媒体文件|*.mp4|图片|*.jpg|所有文件|*.*";
            opd.ShowDialog();
            string filepath = opd.FileName;
            using (FileStream fsRead = new FileStream(filepath,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, buffer.Length);

            }




                

        }
    }
}