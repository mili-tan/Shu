using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var textChars = textBox1.Text.ToCharArray().ToList();
            var strList = new List<List<char>>();
            for (int i = 0; i < textChars.Count; i += 5) strList.Add(textChars.Skip(i).Take(5).ToList());

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    foreach (var item in strList)
                    {
                        textBox2.Text += item[i];
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    //throw;
                }

                textBox2.Text += Environment.NewLine;
            }
        }
    }
}
