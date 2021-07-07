using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.BLL;

namespace WebApplication1
{
    public partial class AllEmployees : System.Web.UI.Page
    {
   
        public EmployeeBLL _employeeBLL;
        public SqlConnection _conn;
        public AllEmployees()
        {
            _employeeBLL = new EmployeeBLL();
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ICMSDBConnectionString"].ConnectionString);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RefreshEmployeeList();
            }
        }

        public void RefreshEmployeeList()
        {
            //new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-60C7F0G;
                        initial catalog=ICMS;persist security info=True;
                        MultipleActiveResultSets=True");
            SqlCommand cmd = new SqlCommand("SELECT * from Employee", _conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            MyGridView.DataSource = ds;
            MyGridView.DataBind();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeBLL _empBLL = new EmployeeBLL();

                var data = _empBLL.GetAllActiveEmployee();
                if (data.Count() > 0)
                {
                    MyGridView.DataSource = data;
                    MyGridView.DataBind();
                }

                else
                {

                    ShowAlert("No Records found");
                }
            }
            catch (Exception ex)
            {
                ShowAlert(ex.Message.ToString());
            }
        }

        private void ShowAlert(string strmsg)
        {
            string str1;
            str1 = "<script language = 'javascript' type = 'text/javascript'> alert('" + strmsg + "');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "JS", str1);
        }

    }
}
    
