using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public partial class LaboratoryHome : System.Web.UI.Page
{
    int cnt;
    string p2;
    string p4;

    SqlConnection cn = new SqlConnection("Data Source=AMEER-PC;Database=ehr2;Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {


                ViewState["cf"] = 0;
                ViewState["m"] = 0;
                string a = Session["id"].ToString();
                cn.Open();
                SqlCommand cm1 = new SqlCommand("select * from linfo5 where id='" + a + "'", cn);
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

                cn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from ldata7", cn);
                cnt = (int)cmd.ExecuteScalar();
                cn.Close();
                txt1.Text = (cnt + 1).ToString();
                ViewState["k"] = (cnt + 1).ToString();

            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        try
        {
            int flbp = 0;
            string bp1 = OboutTextBox5.Text;
            int bp2 = Convert.ToInt32(bp1);
            if (bp2 < 0 || bp2 > 350)
            {

                Response.Write("<script> alert('Blood pressure is wrong')</script>");
                flbp = 1;
            }
            string bp3 = OboutTextBox1.Text;
            int bp4 = Convert.ToInt32(bp3);
            if (bp4 < 0 || bp4 > 350)
            {

                Response.Write("<script> alert('Blood pressure is wrong')</script>");
                flbp = 1;
            }
            string pl1 = OboutTextBox2.Text;
            int pl2 = Convert.ToInt32(pl1);
            if (pl2 < 0 || pl2 > 200)
            {

                Response.Write("<script> alert('Pulse is wrong')</script>");
                flbp = 1;
            }

            string rp1 = OboutTextBox3.Text;
            int rp2 = Convert.ToInt32(rp1);
            if (rp2 < 0 || rp2 > 60)
            {

                Response.Write("<script> alert('Respiration is wrong')</script>");
                flbp = 1;
            }
            string tp1 = OboutTextBox4.Text;
            int tp2 = Convert.ToInt32(tp1);
            if (tp2 < 35 || tp2 > 42)
            {

                Response.Write("<script> alert('Temperature is wrong')</script>");
                flbp = 1;
            }
            if (flbp == 0)
            {
            string cnt1 = ViewState["k"].ToString();
            cn.Open();
            string p1;

            p1 = pn.Text;

            SqlCommand cm1 = new SqlCommand("select name from pinfo5 where id='" + p1 + "'", cn);
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                    p2 = dr1["name"].ToString();
                }
            }
            string p3 = ct.Text;

            cn.Close();
            cn.Open();
            SqlCommand cm2 = new SqlCommand("select name from dinfo5 where id='" + p3 + "'", cn);
            SqlDataReader dr2 = cm2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    p4 = dr2["name"].ToString();
                }
            }
            // string p1 = pn.Text;
            //string p2;
            DateTime p5 = new DateTime();
            cn.Close();
            cn.Open();
            SqlCommand cm3 = new SqlCommand("select dob from pinfo5 where id='" + p1 + "'", cn);
            SqlDataReader dr3 = cm3.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    p5 = Convert.ToDateTime(dr3["dob"]);
                }
            }
            DateTime cc1 = DateTime.Now.Date;
            TimeSpan tp = cc1.Subtract(p5);
            cn.Close();

            double cc2 = tp.TotalDays;
            int ag1 = Convert.ToInt32(cc2 / 365);
            string ag2 = ag1.ToString();
            string tm1 = (DateTime.Now.TimeOfDay).ToString();
            FileUpload1.PostedFile.SaveAs(Server.MapPath("Files2/" + FileUpload1.FileName));
            string filepath1 = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files2\" + FileUpload1.FileName;
            // string filepath1 = Path.GetFullPath(FileUpload1.PostedFile.FileName);
            // string jp1 = FileUpload1.FileName;
            // string filepath1 = Server.MapPath(jp1);
            //string filepath1="@"+filepath12;
            //string ts = FileUpload1.PostedFile.ToString();
            // string fileName=FileUpload1.FileName;
            // string pn = TextBox1.Text + TextBox2.Text + ".jpg";
            string pn1 = cnt1.ToString() + ".jpg";

            string output = Server.MapPath("Files/" + pn1);
            enclass.EncryptFile(filepath1, output, "1234512345678976");
            System.IO.File.Delete(filepath1);
            string dataFile;
            string signedFile;
            //If no file names are specified, create them. 

            dataFile = output;
            signedFile = Server.MapPath("Files1/" + pn1);

            //if (!File.Exists(dataFile))
            //{
            // Create a file to write to. 
            //  using (StreamWriter sw = File.CreateText(dataFile))
            //{
            //  sw.WriteLine("Here is a message to sign");
            //}
            //}


            try
            {
                // Create a random key using a random number generator. This would be the 
                //  secret key shared by sender and receiver. 
                byte[] secretkey = new Byte[64];
                //RNGCryptoServiceProvider is an implementation of a random number generator. 
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    // The array is now filled with cryptographically strong random bytes.
                    //rng.GetBytes(secretkey);
                    string ab = "1234512345678976";
                    // ab.GetBytes(secretkey);
                    secretkey = ASCIIEncoding.UTF8.GetBytes(ab);
                    // Use the secret key to sign the message file.
                    enclass.SignFile(secretkey, dataFile, signedFile);
                    System.IO.File.Delete(dataFile);

                    // Verify the signed file

                    //VerifyFile(secretkey, signedFile);
                }
            
            }
            catch (IOException e1)
            {
                Console.WriteLine("Error: File not found", e1);
            }
               // string b="abc";
                string bp5=bp2.ToString()+"/"+bp4.ToString();
                string desn1 = OboutTextBox6.Text;
                string bp6 = enclass.encypt1(bp5);
                string pl3 = enclass.encypt1(pl2.ToString());
                string rp3 = enclass.encypt1(rp2.ToString());
                string tp3 = enclass.encypt1(tp2.ToString());
                string desn2 = enclass.encypt1(desn1);
            SqlCommand cmd = new SqlCommand("insert into ldata7 values('" + cnt1 + "','" + pn.Text + "','" + p2 + "','" + ag2 + "','"+bp6+"','"+pl3+"','"+rp3+"','"+tp3+"','"+desn2+"','" + pn1 + "','" + p3 + "','" + p4 + "','" + un.Text + "','" + cc1 + "','" + tm1 + "')", cn);
            SqlCommand cmd1 = new SqlCommand("insert into pdata7 values('" + cnt1 + "','" + pn.Text + "','" + p2 + "','" + ag2 + "','" + bp6 + "','" + pl3 + "','" + rp3 + "','" + tp3 + "','" + desn2 + "','" + pn1 + "','" + p3 + "','" + p4 + "','" + un.Text + "','" + cc1 + "','" + tm1 + "','nil')", cn);
            SqlCommand cmd2 = new SqlCommand("insert into ddata7 values('" + cnt1 + "','" + pn.Text + "','" + p2 + "','" + ag2 + "','" + bp6 + "','" + pl3 + "','" + rp3 + "','" + tp3 + "','" + desn2 + "','" + pn1 + "','" + p3 + "','" + p4 + "','" + un.Text + "','" + cc1 + "','" + tm1 + "','nil')", cn);
            cn.Open();
            int a1 = cmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            int a2 = cmd1.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            int a3 = cmd2.ExecuteNonQuery();
            cn.Close();
            if (a1 > 0 && a2 > 0 && a3 > 0)
            {
                Response.Write("<script> alert('success  ')</script>");

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
    protected void Button1_Click(object sender, EventArgs e)
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

    protected void OboutButton1_Click(object sender, EventArgs e)
    {
        try
        {

            if (pn.Text == "")
            {
                Response.Write("<script> alert('Enter patient Id')</script>");
            }
            else
            {

                if (Convert.ToInt32(ViewState["cf"]) == 0)
                {
                    Image2.Visible = true;
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label10.Visible = true;
                    cn.Open();
                    SqlCommand cm1 = new SqlCommand("select * from pinfo5 where id='" + pn.Text + "'", cn);
                    SqlDataAdapter dm1 = new SqlDataAdapter(cm1);
                    DataSet dn1 = new DataSet();
                    dm1.Fill(dn1);
                    string p1 = dn1.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                    Image2.ImageUrl = "image1/" + p1;
                    Label2.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label4.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                    Label6.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                    Label8.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                    Label10.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

                    cn.Close();
                    ViewState["cf"] = 1;
                }
                else
                {
                    Image2.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                    Label9.Visible = false;
                    Label10.Visible = false;
                    ViewState["cf"] = 0;
                }
            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");

        }
    }
    protected void OboutButton2_Click(object sender, EventArgs e)
    {
        try
        {

            if (ct.Text == "")
            {
                Response.Write("<script> alert('Enter Doctor Id')</script>");
            }
            else
            {

                if (Convert.ToInt32(ViewState["cf"]) == 0)
                {
                    Image2.Visible = true;
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    cn.Open();
                    SqlCommand cm1 = new SqlCommand("select * from dinfo5 where id='" + ct.Text + "'", cn);
                    SqlDataAdapter dm1 = new SqlDataAdapter(cm1);
                    DataSet dn1 = new DataSet();
                    dm1.Fill(dn1);
                    string p1 = dn1.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                    Image2.ImageUrl = "image1/" + p1;
                    Label2.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label4.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                    Label6.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                    Label8.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                    Label10.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    Label12.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    cn.Close();
                    ViewState["cf"] = 1;
                }
                else
                {
                    Image2.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                    Label9.Visible = false;
                    Label10.Visible = false;
                    Label11.Visible = false;
                    Label12.Visible = false;
                    ViewState["cf"] = 0;
                }
            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    protected void OboutButton3_Click(object sender, EventArgs e)
    {
        try
        {


            if (un.Text == "")
            {
                Response.Write("<script> alert('Enter Pharmacy Id')</script>");
            }
            else
            {

                if (Convert.ToInt32(ViewState["cf"]) == 0)
                {
                    //Image2.Visible = true;
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label10.Visible = true;
                    // Label11.Visible = true;
                    //Label12.Visible = true;
                    cn.Open();
                    SqlCommand cm1 = new SqlCommand("select * from phinfo5 where id='" + un.Text + "'", cn);
                    SqlDataAdapter dm1 = new SqlDataAdapter(cm1);
                    DataSet dn1 = new DataSet();
                    dm1.Fill(dn1);
                    //string p1 = dn1.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                    //Image2.ImageUrl = "image1/" + p1;
                    Label2.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label4.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                    Label6.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                    Label8.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                    Label10.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                    // Label12.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                    cn.Close();
                    ViewState["cf"] = 1;
                }
                else
                {
                    Image2.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                    Label9.Visible = false;
                    Label10.Visible = false;
                    ViewState["cf"] = 0;
                }
            }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    


}