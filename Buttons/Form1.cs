using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            String CallumString = ("You clicked the button!");
             inputbox = MessageBox.Show("Hello!", CallumString, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (button1 == inputbox.Yes );
            {
                MessageBox.Show("You clicked Yes!");
            }
            else;
            {
                MessageBox.Show("You clicked No!");
            } 
            */

            String SecondString = ("Hello World!");
            MessageBox.Show(SecondString);


            
        }
    }
}
