using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Data Source=AMEER-PC;Database=ehr2;Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        try
        {
            cn.Open();
            int l = 0;
            SqlCommand com = new SqlCommand("select id from dinfo5 where uname='" + txt1.Text + "'and pwd='" + txt2.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    string id = dr["id"].ToString();

                    l = 1;
                    Session["UName"] = txt1.Text.ToString();
                    Session["pwd"] = txt2.Text.ToString();
                    Session["id"] = id;
                    Response.Redirect("doctorhome.aspx");
                }

            }
            cn.Close();
            cn.Open();
            SqlCommand com1 = new SqlCommand("select id from pinfo5 where uname='" + txt1.Text + "'and pwd='" + txt2.Text + "'", cn);
            SqlDataReader dr1 = com1.ExecuteReader();
            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                    string id1 = dr1["id"].ToString();
                    l = 1;
                    Session["UName"] = txt1.Text.ToString();
                    Session["pwd"] = txt2.Text.ToString();
                    Session["id"] = id1;
                    Response.Redirect("patienthome.aspx");
                }
            }
            cn.Close();
            cn.Open();
            SqlCommand com2 = new SqlCommand("select id from linfo5 where uname='" + txt1.Text + "'and pwd='" + txt2.Text + "'", cn);
            SqlDataReader dr2 = com2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    string id2 = dr2["id"].ToString();
                    l = 1;
                    Session["UName"] = txt1.Text.ToString();
                    Session["pwd"] = txt2.Text.ToString();
                    Session["id"] = id2;
                    Response.Redirect("laboratoryhome.aspx");
                }
            }
            cn.Close();
            cn.Open();
            SqlCommand com3 = new SqlCommand("select id from phinfo5 where uname='" + txt1.Text + "'and pwd='" + txt2.Text + "'", cn);
            SqlDataReader dr3 = com3.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    string id3 = dr3["id"].ToString();
                    l = 1;
                    Session["UName"] = txt1.Text.ToString();
                    Session["pwd"] = txt2.Text.ToString();
                    Session["id"] = id3;
                    Response.Redirect("pharmacyhome.aspx");
                }
            }
            cn.Close();








            if (l == 0)
            {

                Response.Write("<script> alert('invalid username or password')</script>");
            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
        
    }
}