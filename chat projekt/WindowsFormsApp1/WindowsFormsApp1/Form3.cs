using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Form2 f2;
        public Form3()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (f2 == null)
                f2 = new Form2("");
            f2.ValueFromForm1(textBox1.Text);
            f2.Show();
            /*
            Form2 f2 = new Form2(textBox1.Text);
            f2.Show();*/
        }
    }
    
}
