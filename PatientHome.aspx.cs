using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;


public partial class PatientHome : System.Web.UI.Page
{
    int k = 0;
    int i = 0;
    string rt;
    string fl1;
    string addr1;
    string em1;
    string ct1;
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
                SqlCommand cm1 = new SqlCommand("select * from pinfo5 where id='" + a + "'", cn);
                SqlDataAdapter dm1 = new SqlDataAdapter(cm1);
                DataSet dn1 = new DataSet();
                dm1.Fill(dn1);
                string p1 = dn1.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                Image2.ImageUrl = "image1/" + p1;
                Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                Label22.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                Label24.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                Label26.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                Label28.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                Label30.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();
                cn.Close();
                SqlCommand com = new SqlCommand("select * from pdata7 where pid='" + a.ToString() + "'", cn);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label11.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(10).ToString();

                    Label12.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(11).ToString();
                    Label13.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label14.Text = a.ToString();
                    Label15.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                    Label16.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(13).ToString();
                    Label31.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(14).ToString();
                    Label18.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(12).ToString();
                    fl1 = ds.Tables[0].Rows[0].ItemArray.GetValue(9).ToString();
                    Label32.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                    string bp1 = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                    string bp2 = enclass.decrypt1(bp1);
                    if (bp2.Equals("t"))
                    {
                        Label36.Text = "Tampered";
                    }
                    else
                    {
                        Label36.Text = bp2;
                    }
                    string pl1 = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    string pl2 = enclass.decrypt1(pl1);
                    if (pl2.Equals("t"))
                    {
                        Label38.Text = "Tampered";
                    }
                    else
                    {
                        Label38.Text = pl2;
                    }
                    string rp1 = ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                    string rp2 = enclass.decrypt1(rp1);
                    if (rp2.Equals("t"))
                    {
                        Label40.Text = "Tampered";
                    }
                    else
                    {
                        Label40.Text = rp2;
                    }
                    string tp1 = ds.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();
                    string tp2 = enclass.decrypt1(tp1);
                    if (tp2.Equals("t"))
                    {
                        Label42.Text = "Tampered";
                    }
                    else
                    {
                        Label42.Text = tp2;
                    }
                    string desn1 = ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                    string desn2 = enclass.decrypt1(desn1);
                    if (desn2.Equals("t"))
                    {
                        TextBox2.Text = "Tampered";
                    }
                    else
                    {
                        TextBox2.Text = desn2;
                    }

                    TextBox1.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(15).ToString();


                    //SqlCommand cmd = new SqlCommand("select en from a3 where cid='" + a + "' and id='" + b + "'", cn);
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //if (dr.HasRows)
                    //{
                    //    while (dr.Read())
                    //    {
                    //        cc = dr["enc"].ToString();
                    //    }
                    //}
                    cn.Close();
                    string ab = "1234512345678976";
                    // ab.GetBytes(secretkey);
                    byte[] secretkey = new Byte[64];
                    secretkey = ASCIIEncoding.UTF8.GetBytes(ab);
                    // Use the secret key to sign the message file.
                    //SignFile(secretkey, dataFile, signedFile);
                    // Verify the signed file

                    // @"D:\a1.txt";
                    string signedFile = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files1\" + fl1;
                    string encr = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files\" + fl1;
                    //string outc = ImageButton1.ImageUrl;
                    bool bl = enclass.VerifyFile(secretkey, signedFile,fl1);
                    if (bl)
                    {
                        Label33.Text = "tampered";
                    }
                    else
                    {
                        // string img1="";
                        //enclass.DecryptFile(encr, @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files3\" + fl1, "1234512345678976");

                        ImageButton2.ImageUrl = "Files3/" + fl1;
                        //System.IO.File.Delete(@"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\WebSite2\Files3\" + cc);
                    }
                }
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
            i = Convert.ToInt32(ViewState["m"].ToString());
            i++;
            ViewState["m"] = i;

            string a = Session["id"].ToString();
            cn.Open();
            SqlCommand com = new SqlCommand("select * from pdata7 where pid='" + a.ToString() + "'", cn);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > i)
                {
                    //Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label11.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(10).ToString();

                    Label12.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(11).ToString();
                    Label13.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                    Label14.Text = a.ToString();
                    Label15.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(2).ToString();
                    Label16.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(13).ToString();
                    Label31.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(14).ToString();
                    Label18.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(12).ToString();
                    fl1 = ds.Tables[0].Rows[i].ItemArray.GetValue(9).ToString();
                    Label32.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(3).ToString();
                    string bp1 = ds.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
                    string bp2 = enclass.decrypt1(bp1);
                    if (bp2.Equals("t"))
                    {
                        Label36.Text = "Tampered";
                    }
                    else
                    {
                        Label36.Text = bp2;
                    }
                    string pl1 = ds.Tables[0].Rows[i].ItemArray.GetValue(5).ToString();
                    string pl2 = enclass.decrypt1(pl1);
                    if (pl2.Equals("t"))
                    {
                        Label38.Text = "Tampered";
                    }
                    else
                    {
                        Label38.Text = pl2;
                    }
                    string rp1 = ds.Tables[0].Rows[i].ItemArray.GetValue(6).ToString();
                    string rp2 = enclass.decrypt1(rp1);
                    if (rp2.Equals("t"))
                    {
                        Label40.Text = "Tampered";
                    }
                    else
                    {
                        Label40.Text = rp2;
                    }
                    string tp1 = ds.Tables[0].Rows[i].ItemArray.GetValue(7).ToString();
                    string tp2 = enclass.decrypt1(tp1);
                    if (tp2.Equals("t"))
                    {
                        Label42.Text = "Tampered";
                    }
                    else
                    {
                        Label42.Text = tp2;
                    }
                    string desn1 = ds.Tables[0].Rows[i].ItemArray.GetValue(8).ToString();
                    string desn2 = enclass.decrypt1(desn1);
                    if (desn2.Equals("t"))
                    {
                        TextBox2.Text = "Tampered";
                    }
                    else
                    {
                        TextBox2.Text = desn2;
                    }

                    TextBox1.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(15).ToString();

                    //SqlCommand cmd = new SqlCommand("select en from a3 where cid='" + a + "' and id='" + b + "'", cn);
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //if (dr.HasRows)
                    //{
                    //    while (dr.Read())
                    //    {
                    //        cc = dr["enc"].ToString();
                    //    }
                    //}
                    cn.Close();
                    string ab = "1234512345678976";
                    // ab.GetBytes(secretkey);
                    byte[] secretkey = new Byte[64];
                    secretkey = ASCIIEncoding.UTF8.GetBytes(ab);
                    // Use the secret key to sign the message file.
                    //SignFile(secretkey, dataFile, signedFile);
                    // Verify the signed file

                    // @"D:\a1.txt";
                    string signedFile = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files1\" + fl1;
                    string encr = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files\" + fl1;
                    //string outc = ImageButton1.ImageUrl;
                    bool bl = enclass.VerifyFile(secretkey, signedFile,fl1);
                    if (bl)
                    {
                        Label33.Text = "tampered";
                    }
                    else
                    {
                        // string img1="";
                        //enclass.DecryptFile(encr, @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files3\" + fl1, "1234512345678976");

                        ImageButton2.ImageUrl = "Files3/" + fl1;
                        //System.IO.File.Delete(@"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\WebSite2\Files3\" + cc);
                    }
                }
            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Response.Redirect(ImageButton2.ImageUrl);
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
