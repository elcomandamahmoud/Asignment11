using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void MSG(string body, string title)
        {
            MessageBox.Show(body, title);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)==false   && string.IsNullOrEmpty(textBox2.Text)==false)
            {
                MSG(textBox1.Text.Trim(), textBox2.Text.Trim());
            }
            else
            {
                MSG("all text boxes are blank, this can not be blanked","error");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
