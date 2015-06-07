using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_016
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getDateButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = myCalendar.SelectedDate.ToString();
        }

        protected void setDateButton_Click(object sender, EventArgs e)
        {
            myCalendar.SelectedDate = DateTime.Parse("6/2/2015");
        }

        protected void showDateButton_Click(object sender, EventArgs e)
        {
            myCalendar.VisibleDate = DateTime.Parse("11/13/1985");
        }

        protected void selectWeekButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Week of " + myCalendar.SelectedDate.ToString(); 
        }

        protected void myCalendar_SelectionChanged(object sender, EventArgs e)
        {
            resultLabel.Text = myCalendar.SelectedDate.ToShortDateString();
        }
    }
}