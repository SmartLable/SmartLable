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

namespace 保存文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfile = new SaveFileDialog();

            sfile.Title = "保存文件对话框";
            sfile.InitialDirectory = @"F:\PJ\杜帅0731\360手机助手Demo-14.2.6更新x2\360手机助手Demo-14.2.6更新x2\360Mobile";

            sfile.Filter = "文本文件|*.txt";

            sfile.ShowDialog();

            string path = sfile.FileName;

            if(path =="")
            {

                return;
            }
     
            using (FileStream fsw = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {


                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsw.Write(buffer, 0, buffer.Length);

            }
            MessageBox.Show("保存成功");


}

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog ft = new FontDialog();
            ft.ShowDialog();
            textBox1.Font = ft.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }
    }
}
