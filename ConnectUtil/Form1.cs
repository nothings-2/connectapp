using System;
using System.Windows.Forms;

namespace ConnectUtil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = $"You've wrote: {textBox1.Text}";
            MessageBox.Show(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text = $"You've wrote: {textBox1.Text}";
            MessageBox.Show(text);
        }
    }
}
