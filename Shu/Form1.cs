using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (checkBoxSBC.Checked) textBox1.Text = ToSBC(textBox1.Text);

            var textChars = textBox1.Text.Replace(Environment.NewLine,"").Replace(" ", "").ToCharArray().ToList();
            var strList = new List<List<char>>();
            var val = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 0; i < textChars.Count; i += val) strList.Add(textChars.Skip(i).Take(val).ToList());

            for (int i = 0; i < val; i++)
            {
                foreach (var item in strList.Where(item => item.Count > i))
                {
                    textBox2.Text += item[i];
                    if (checkBoxSpaces.Checked) textBox2.Text += comboBox.Text;
                }

                textBox2.Text += Environment.NewLine;
            }
        }

        private void FontSong_CheckedChanged(object sender, EventArgs e)
        {
            Font = checkBoxFontSong.Checked ? new Font("宋体",9) : new Font("微软雅黑", 7);
        }

        public static string ToSBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32) c[i] = (char) 12288;
                else { if (c[i] < 127) c[i] = (char) (c[i] + 65248); }
            }

            return new string(c);
        }
    }
}
