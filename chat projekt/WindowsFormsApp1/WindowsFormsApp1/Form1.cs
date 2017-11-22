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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //class der gør Form2 ikke kan åbnes mere end en gang! 
        public class Form : Form2
        {
            public Form():base("")
            {

            }
            public static Form2 _instance;
            public static Form2 GetInstance()
            {
                if (_instance == null) _instance = new Form2("");
                return _instance;
            }
        }

        //vilkårenen for at åbne form 2
        //User_click er action for alle knapper i form 1
        private void User_click(object sender, EventArgs e)
        {
            //Event Handler for tryk på en af userne
            
            

            Form2 form = Form.GetInstance();
            if (!form.Visible)
            {
                Button c = (Button)sender;
                //form.SetString(c.Text); //Text link
                form.Show();
                
            }
            else
            {
                form.BringToFront();
            }


            //Åbning af form 3
            Form3 frm3 = new Form3();
            frm3.Show();
            



        }

        /*
        //Event Handler for tryk på en af userne
        Button pik = (Button)sender;

        //open form 2

        Form2 frm2 = new Form2();

        frm2.SetString(c.Text); //Text link
        frm2.Show();
        */


        //open form 3        
 
        /*
        private void firma_click(object sender, EventArgs e)
        {
            //Event Handler
            Button c = (Button)sender;

            //open form 2
            Ower frm = new Ower();

            frm.SetString(c.Text); //Text link 
            frm.Show();
        }*/
    }
}
