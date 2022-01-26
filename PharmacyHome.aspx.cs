using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class PharmacyHome : System.Web.UI.Page
{

    SqlConnection cn = new SqlConnection("Data Source=AMEER-PC;Database=ehr2;Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ViewState["m"] = 0;
                string a = Session["id"].ToString();
                cn.Open();
                SqlCommand cm1 = new SqlCommand("select * from phinfo5 where id='" + a + "'", cn);
                SqlDataAdapter dm1 = new SqlDataAdapter(cm1);
                DataSet dn1 = new DataSet();
                dm1.Fill(dn1);
                //string p1 = dn1.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                //Image2.ImageUrl = "image1/" + p1;
                Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                Label22.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                Label24.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                Label26.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                Label28.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                cn.Close();
                SqlCommand com = new SqlCommand("select * from phdata7 where phid='" + a.ToString() + "' and status='0'", cn);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label11.Text = a.ToString();
                    Label12.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                    Label13.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                    TextBox2.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                    Label16.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                    Label31.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    TextBox3.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                    Label33.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();
                    // fl1 = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                    Label34.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                    Label14.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(10).ToString();
                }
            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cm1 = new SqlCommand("update phdata7 set status='1' where did='" + Label12.Text + "' and pid='" + Label16.Text + "' and cid='"+Label14.Text+"'", cn);
            cn.Open();
            int c1 = cm1.ExecuteNonQuery();
            cn.Close();
            if (c1 > 0)
            {
                Response.Write("<script> alert('Successfully Updated')</script>");
            }
            else
            {
                Response.Write("<script> alert('Error in updation')</script>");
            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int i = Convert.ToInt32(ViewState["m"].ToString());
            i++;
            ViewState["m"] = i;

            string a = Session["id"].ToString();
            cn.Open();
            SqlCommand com = new SqlCommand("select * from phdata7 where  phid='" + a.ToString() + "' and status='0'", cn);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if ((ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows.Count > i))
            {
                Label11.Text = a.ToString();
                Label12.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(1).ToString();
                Label13.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(2).ToString();
                TextBox2.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(3).ToString();
                Label16.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
                Label31.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(5).ToString();
                TextBox3.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(6).ToString();
                Label33.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(7).ToString();
                // fl1 = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                Label34.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(8).ToString();
                Label14.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(10).ToString();
            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
            
            

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            Session.Abandon();
            Response.Redirect("Default3.aspx");
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        } 
    }
}