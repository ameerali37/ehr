using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PharmacyRegister : System.Web.UI.Page
{
    int cnt;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SqlConnection cn = new SqlConnection("Data Source=AMEER-PC;Database=ehr2;Integrated Security=true");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from phinfo5", cn);
            cnt = (int)cmd.ExecuteScalar();
            cn.Close();
            txt1.Text = (cnt + 1).ToString();
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
   
    protected void btn1_Click1(object sender, EventArgs e)
    {
        try
        {
            int cnt1 = cnt + 1;
            SqlConnection cn = new SqlConnection(GetConnectionString());
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into phinfo5 values('" + cnt1 + "','" + pn.Text + "','" + ad.Text + "','" + em.Text + "','" + ct.Text + "','" + un.Text + "','" + pw.Text + "')", cn);
            int a1 = cmd.ExecuteNonQuery();
            if (a1 > 0)
            {
                //Response.Write("<script> alert('success  ')</script>");
                Session["UName"] = un.Text.ToString();
                Session["pwd"] = pw.Text.ToString();
                Session["id"] = cnt1.ToString();
                Response.Redirect("Pharmacyhome.aspx");
            }
            else
            {
                Response.Write("<script> alert('error')</script>");
            }
            cn.Close();
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
}