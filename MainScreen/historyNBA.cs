using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    static class historyNBA
    {
        public static void getHowOldNBA(Label p)
        {
            DateTime d = DateTime.Now;
            int year = d.Year;
            int age = year - 1946; 
            p.Text = "The current season is "+ (year-1) +"–"+year+", and the NBA already has a history of "+age+" years";
        }
    }
}
