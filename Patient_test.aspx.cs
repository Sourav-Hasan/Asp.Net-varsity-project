using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workshop
{
    public partial class Patient_test : System.Web.UI.Page
    {
        DB db = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                this.Title = "Entry Patient";
                DropDownList1.Items.Add(new ListItem("Null"));
                DropDownList1.Items.Add(new ListItem("Dr.Nurul"));
                DropDownList1.Items.Add(new ListItem("Dr.Amzad"));
                DropDownList1.Items.Add(new ListItem("Dr.Idris"));
                DropDownList1.Items.Add(new ListItem("Dr.Suraiya"));
                DropDownList1.Items.Add(new ListItem("Dr.Farzana"));
                //grid_patient();
                

            }
        }
        protected void Button_submit_Click(object sender, EventArgs e)
        {

            if (TextBox_name.Text == String.Empty ||TextBox_address.Text == String.Empty)
            {
                Response.Write("<script>alert('Please must enter  Username and Address')</script>");
            }
            else
            {
                string _query = @"INSERT INTO [dbo].[PatientTest]
           ([P_id]
           ,[P_name]
           ,[P_address]
           ,[P_doctor])
     VALUES
           ('" + Box_id.Value.ToString() + "', '" + TextBox_name.Text + "', '" + TextBox_address.Text + "', '" + Label_ass_doc.Text + "')";
                db.ExecuteQuery(_query);

                // grid_patient();

                Response.Redirect("~/Patient_list.aspx");
            }
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Label_ass_doc.Text = DropDownList1.SelectedValue;
        }
    }
}