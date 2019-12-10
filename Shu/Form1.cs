using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Shu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            var textChars = textBox1.Text.Replace(Environment.NewLine,"").Replace(" ", "").ToCharArray().ToList();
            var strList = new List<List<char>>();
            var val = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 0; i < textChars.Count; i += val) strList.Add(textChars.Skip(i).Take(val).ToList());

            for (int i = 0; i < val; i++)
            {
                foreach (var item in strList.Where(item => item.Count > i))
                {
                    textBox2.Text += item[i];
                    if (Spaces.Checked) textBox2.Text += @" ";
                }

                textBox2.Text += Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
