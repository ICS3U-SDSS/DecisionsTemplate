using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ageButton_Click(object sender, EventArgs e)
        {
            /* Create a variable to hold a person's age. Then use that variable
               to determine if the person is old enough to play a game
               that requires the user to be 18 or older. Display an
               appropriate message based on whether they can or can't vote            
             */


        }

        private void xpButton_Click(object sender, EventArgs e)
        {
            /*  Create a variable to hold the xp gained in a level. If the 
             *  player gained over 100 xp then they get double the xp for 
             *  each xp gained over 100.
             *  
             *  Sample output for input 80
             *  You gained 80 xp
             *  
             *  Sample output for input 120
             *  You gained 140 xp
             */
             
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            /* Create a program that determines the max value between 2 values 
               inputted by the user. The output should match the following:

               Sample output for inputs 34, 12
               The max value is: 34

               Sample output for inputs 22, 77
               The max value is: 77
            */
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines if an entered year
            /// is a leap year. The output should match the following:
            /// 
            /// Sample output for inputs 2002
            /// 2002 is not a leap year
            /// 
            /// Sample output for inputs 2016
            /// 2016 is a leap year
           

        }


    }
}
