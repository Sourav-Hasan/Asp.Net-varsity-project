using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Workshop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Title = "Login";

            }

        }
        protected void Button_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Users where User_name='" + TextBox_name.Text + "' and Password ='" + TextBox_pass.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Patient_test.aspx");
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenWindow", "window.open('DoctorList.aspx','_newtab');", true);
            }
            else
            {
                Label1.Text = "Invalid username or password.";
                //Response.Write("<script>alert('Please enter valid Username and Password')</script>");
                //Response.Write("Username is wrong");


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.html");
        }

        //protected void LinkButton1_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("HomePage.html");
        //}

        //protected void LinkButton3_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("Patient_list.aspx");
        //}

        //protected void LinkButton4_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("DoctorList.aspx");
        //}
    }
}