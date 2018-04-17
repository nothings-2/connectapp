using System;
using System.Windows.Forms;

namespace ConnectUtil
{
    public partial class Form1 : Form
    {
        public StatusType StatusType { get; set; }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboValue = comboBox1.Text == "1"
                ? StatusType.Active.ToString()
                : textBox1.Text == "override"
                    ? textBox1.Text
                    : StatusType.Inactive.ToString();

            MessageBox.Show(comboValue);
        }
    }

    public enum StatusType
    {
        Active = 1, 
        Inactive = 2
    }
}
