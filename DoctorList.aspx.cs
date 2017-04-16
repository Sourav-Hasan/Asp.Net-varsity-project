using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Workshop
{
    public partial class DoctorList : System.Web.UI.Page
    {
        DB db = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Title = "Available Doctor";
                grid_patient();
            }
            
        }
        protected void grid_patient()
        {

            string _query = @"SELECT [Doctor_name]
                                  ,[Special]
                                  ,[Doctor_phone]
                                  ,[Room_no]
                              FROM [dbo].[Doctor_test]";
            GridView1.DataSource = db.GetDataTable(_query);
            GridView1.DataBind();
        }

      
    }
}