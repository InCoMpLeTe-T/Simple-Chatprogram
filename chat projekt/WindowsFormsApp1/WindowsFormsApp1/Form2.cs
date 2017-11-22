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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
     
            public Form2(string message)
            {
                InitializeComponent();
                //textBox2.Text = message;
            }
        public void ValueFromForm1(string value)
        {
            textBox2.Text = value;
        }

        /*internal string TextString = "";
        internal string user;
        public Form2()
        {
            InitializeComponent();
        }
        public void SetString(string input)
        {
            TextString = input;
            return;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

            textBox1.Text = TextString;
        }


        public void setTextBoxes()
        {
            textBox1.Text = user;
         
        }*/

    }
}
