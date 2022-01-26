using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DoctorRegister : System.Web.UI.Page
{
    int cnt;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SqlConnection cn = new SqlConnection("Data Source=AMEER-PC;Database=ehr2;Integrated Security=true");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from dinfo5", cn);
            cnt = (int)cmd.ExecuteScalar();
            cn.Close();
            txt1.Text = (cnt + 1).ToString();
            cn.Close();
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    public string GetConnectionString()
    {
        //sets the connection string from your web config file "ConnString" is the name of your Connection String
        return System.Configuration.ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection cn = new SqlConnection(GetConnectionString());
            int cnt1 = cnt + 1;
            string un1 = un.Text;
            cn.Open();
            SqlCommand cmd4 = new SqlCommand("select count(*) from dinfo5 where uname='" + un1 + "'", cn);
            int cnt4 = (int)cmd4.ExecuteScalar();
            SqlCommand cmd5 = new SqlCommand("select count(*) from pinfo5 where uname='" + un1 + "'", cn);
            int cnt5 = (int)cmd5.ExecuteScalar();
            SqlCommand cmd6 = new SqlCommand("select count(*) from phinfo5 where uname='" + un1 + "'", cn);
            int cnt6 = (int)cmd6.ExecuteScalar();
            SqlCommand cmd7 = new SqlCommand("select count(*) from linfo5 where uname='" + un1 + "'", cn);
            int cnt7 = (int)cmd7.ExecuteScalar();
            cn.Close();
            if (cnt4 > 0 || cnt5 > 0 || cnt6 > 0 || cnt7 > 0)
            {

                Response.Write("<script> alert('Username Already Exist  ')</script>");
            }
                

            else
            {
                string pic1 = FileUpload1.FileName;
                string pic2 = "d" + cnt1 + FileUpload1.FileName;

                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into dinfo5 values('" + cnt1 + "','" + dn.Text + "','" + ddl1.SelectedItem.ToString() + "','" + ad.Text + "','" + em.Text + "','" + ct.Text + "','" + un.Text + "','" + pw.Text + "','" + pic2 + "')", cn);
                int a1 = cmd.ExecuteNonQuery();
                if (a1 > 0)
                {
                   // Response.Write("<script> alert('success  ')</script>");

                    FileUpload1.PostedFile.SaveAs(Server.MapPath("image1/" + pic2));
                    Session["UName"] = un.Text.ToString();
                    Session["pwd"] = pw.Text.ToString();
                    Session["id"] = cnt1.ToString();
                    Response.Redirect("doctorhome.aspx");
                }
                else
                {
                    Response.Write("<script> alert('error')</script>");
                }
                cn.Close();
            }
        }
        catch (Exception e1)
        {
            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
}