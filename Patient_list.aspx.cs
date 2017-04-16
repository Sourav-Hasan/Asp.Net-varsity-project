using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workshop
{
    public partial class Patient_list : System.Web.UI.Page
    {
        DB db = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                grid_patient();
               

            }

        }
        protected void grid_patient()
        {
            string _query = @"SELECT [P_id]
                                  ,[P_name]
                                  ,[P_address]
                                  ,[P_doctor]
                              FROM [dbo].[PatientTest]";
            GridView_p.DataSource = db.GetDataTable(_query);
            GridView_p.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Patient_test.aspx");
        }
    }
}