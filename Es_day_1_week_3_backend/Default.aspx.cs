using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Es_day_1_week_3_backend
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            testParagrafo.InnerText = ConfigurationManager.AppSettings["candidatoName"];
            testParagrafo2.InnerText = ConfigurationManager.AppSettings["candidatoSurname"];
        }
    }
}