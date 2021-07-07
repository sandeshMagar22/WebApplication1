using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Employee : System.Web.UI.Page
    {
        public string Gender { get; internal set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMainTitle.Visible = false;

        }
    }
}