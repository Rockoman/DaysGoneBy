using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysGoneBy
{
    public partial class Form1 : Form
    {
        double days;
        public Form1()
        {
            InitializeComponent();
        }


        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            //gives the variable the total value of days in between each date
            days = (dateEnd.Value - dateStart.Value).TotalDays;
            //convert the variable to an int
            int newDay = Convert.ToInt32(days);
            //display the total number of days between each date
            lblDays.Text = "There are " + newDay.ToString() + " days between " + dateStart.Value.ToShortDateString() +" and " + dateEnd.Value.ToShortDateString() + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
