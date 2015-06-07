using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            
            int result = DateTime.Compare(fristCalendar.SelectedDate, secondCalendar.SelectedDate);

            TimeSpan resultSpan = new TimeSpan();

            if (result == -1) { resultSpan = secondCalendar.SelectedDate.Subtract(fristCalendar.SelectedDate); }
            else { resultSpan = fristCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate); }

            resultLabel.Text = resultSpan.TotalDays.ToString();



        }
    }
}