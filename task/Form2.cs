using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    internal partial class Form2 : Form
    {
        //public Form MainForm { get; set; }

        public string Label1Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string TextBox1Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
