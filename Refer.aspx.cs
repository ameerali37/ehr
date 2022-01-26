using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class Refer : System.Web.UI.Page
{
    int k = 0;
    int i = 0;
    string rt;
    string fl1;
    string fl11;
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
                SqlCommand com = new SqlCommand("select * from rfddata8 where rfid='" + a.ToString() + "' and fl='0'", cn);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label44.Text = a.ToString();
                    Label11.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                    Label12.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                    Label13.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                    Label14.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                    Label15.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    Label32.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                    Label16.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();

                    Label31.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                    Label18.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(9).ToString();
                    string bp1 = ds.Tables[0].Rows[0].ItemArray.GetValue(10).ToString();
                    string bp2 = enclass.decrypt1(bp1);
                    if (bp2.Equals("t"))
                    {
                        Label50.Text = "Tampered";
                    }
                    else
                    {
                        Label50.Text = bp2;
                    }
                    string pl1 = ds.Tables[0].Rows[0].ItemArray.GetValue(11).ToString();
                    string pl2 = enclass.decrypt1(pl1);
                    if (pl2.Equals("t"))
                    {
                        Label52.Text = "Tampered";
                    }
                    else
                    {
                        Label52.Text = pl2;
                    }
                    string rp1 = ds.Tables[0].Rows[0].ItemArray.GetValue(12).ToString();
                    string rp2 = enclass.decrypt1(rp1);
                    if (rp2.Equals("t"))
                    {
                        Label54.Text = "Tampered";
                    }
                    else
                    {
                        Label54.Text = rp2;
                    }
                    string tp1 = ds.Tables[0].Rows[0].ItemArray.GetValue(13).ToString();
                    string tp2 = enclass.decrypt1(tp1);
                    if (tp2.Equals("t"))
                    {
                        Label56.Text = "Tampered";
                    }
                    else
                    {
                        Label56.Text = tp2;
                    }
                    fl1 = ds.Tables[0].Rows[0].ItemArray.GetValue(14).ToString();
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
                       // enclass.DecryptFile(encr, @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files3\" + fl1, "1234512345678976");

                        ImageButton2.ImageUrl = "Files3/" + fl1;
                        //System.IO.File.Delete(@"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\WebSite2\Files3\" + cc);
                    }
                }
                ViewState["n"] = 0;

                SqlCommand com1 = new SqlCommand("select * from rfddata8 where did='" + a.ToString() + "' and fl='1'", cn);

                SqlDataAdapter da1 = new SqlDataAdapter(com1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    //Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label46.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    Label20.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                    Label22.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                    Label24.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                    Label26.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                    Label28.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                    Label30.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                    Label35.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();

                    Label37.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                    Label39.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(9).ToString();
                    string bp3 = ds1.Tables[0].Rows[0].ItemArray.GetValue(10).ToString();
                    string bp4 = enclass.decrypt1(bp3);
                    if (bp4.Equals("t"))
                    {
                        Label59.Text = "Tampered";
                    }
                    else
                    {
                        Label59.Text = bp4;
                    }
                    string pl3 = ds1.Tables[0].Rows[0].ItemArray.GetValue(11).ToString();
                    string pl4 = enclass.decrypt1(pl3);
                    if (pl4.Equals("t"))
                    {
                        Label61.Text = "Tampered";
                    }
                    else
                    {
                        Label61.Text = pl4;
                    }
                    string rp3 = ds1.Tables[0].Rows[0].ItemArray.GetValue(12).ToString();
                    string rp4 = enclass.decrypt1(rp3);
                    if (rp4.Equals("t"))
                    {
                        Label63.Text = "Tampered";
                    }
                    else
                    {
                        Label63.Text = rp4;
                    }
                    string tp3 = ds1.Tables[0].Rows[0].ItemArray.GetValue(13).ToString();
                    string tp4 = enclass.decrypt1(tp3);
                    if (tp4.Equals("t"))
                    {
                        Label65.Text = "Tampered";
                    }
                    else
                    {
                        Label65.Text = tp4;
                    }
                    fl11 = ds1.Tables[0].Rows[0].ItemArray.GetValue(14).ToString();
                    OboutTextBox1.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(15).ToString();
                    OboutTextBox3.Text = ds1.Tables[0].Rows[0].ItemArray.GetValue(16).ToString();


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
                    string signedFile = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files1\" + fl11;
                    string encr = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files\" + fl11;
                    //string outc = ImageButton1.ImageUrl;
                    bool bl = enclass.VerifyFile(secretkey, signedFile,fl1);
                    if (bl)
                    {
                        Label41.Text = "tampered";
                    }
                    else
                    {
                        // string img1="";
                        //enclass.DecryptFile(encr, @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files3\" + fl11, "1234512345678976");

                        ImageButton1.ImageUrl = "Files3/" + fl11;
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand ecmd = new SqlCommand("update rfddata8 set todes='" + OboutTextBox2.Text + "' where  cid='" + Label13.Text + "'", cn);
            SqlCommand ecmd1 = new SqlCommand("update rfddata8 set fl='1' where  cid='" + Label13.Text + "'", cn);
            cn.Open();
            int v1 = ecmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            int v2 = ecmd1.ExecuteNonQuery();
            cn.Close();

            if (v1 > 0 && v2 > 0)
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
            i = Convert.ToInt32(ViewState["m"].ToString());
            i++;
            ViewState["m"] = i;

            string a = Session["id"].ToString();
            cn.Open();
            SqlCommand com = new SqlCommand("select * from rfddata8 where rfid='" + a.ToString() + "' and fl='0'", cn);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if ((ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows.Count > i))
            {
                //Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                Label44.Text = a.ToString();
                Label11.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(1).ToString();
                Label12.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(2).ToString();
                Label13.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(3).ToString();
                Label14.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
                Label15.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(5).ToString();
                Label32.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(6).ToString();
                Label16.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(7).ToString();

                Label31.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(8).ToString();
                Label18.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(9).ToString();
                string bp1 = ds.Tables[0].Rows[i].ItemArray.GetValue(10).ToString();
                string bp2 = enclass.decrypt1(bp1);
                if (bp2.Equals("t"))
                {
                    Label50.Text = "Tampered";
                }
                else
                {
                    Label50.Text = bp2;
                }
                string pl1 = ds.Tables[0].Rows[i].ItemArray.GetValue(11).ToString();
                string pl2 = enclass.decrypt1(pl1);
                if (pl2.Equals("t"))
                {
                    Label52.Text = "Tampered";
                }
                else
                {
                    Label52.Text = pl2;
                }
                string rp1 = ds.Tables[0].Rows[i].ItemArray.GetValue(12).ToString();
                string rp2 = enclass.decrypt1(rp1);
                if (rp2.Equals("t"))
                {
                    Label54.Text = "Tampered";
                }
                else
                {
                    Label54.Text = rp2;
                }
                string tp1 = ds.Tables[0].Rows[i].ItemArray.GetValue(13).ToString();
                string tp2 = enclass.decrypt1(tp1);
                if (tp2.Equals("t"))
                {
                    Label56.Text = "Tampered";
                }
                else
                {
                    Label56.Text = tp2;
                }
                fl1 = ds.Tables[0].Rows[i].ItemArray.GetValue(14).ToString();
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
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        try
        {
            Table t = new Table();
            // t.Attributes.Add("BorderColor", "black");
            t.Attributes.Add("style", "border: solid 3px Red");

            TableRow tr1 = new TableRow();
            TableCell tc1 = new TableCell();
            TableCell tc2 = new TableCell();
            TableCell tc3 = new TableCell();
            TableCell tc4 = new TableCell();
            TableCell tc5 = new TableCell();
            TableCell tc6 = new TableCell();
            TableCell tc7 = new TableCell();
            TableCell tc8 = new TableCell();
            TableCell tc9 = new TableCell();
            TableCell tc10 = new TableCell();
            TableCell tc11 = new TableCell();
            TableCell tc12 = new TableCell();
            TableCell tc13 = new TableCell();
            TableCell tc14 = new TableCell();
            TableCell tc15 = new TableCell();
            TableCell tc16 = new TableCell();
            tc1.ID = "t1";
            Label lblSName1 = new Label();
            lblSName1.ID = "l1";
            lblSName1.Text = "Checkup Id";
            tc1.Controls.Add(lblSName1);
            tr1.Controls.Add(tc1);
            tc2.ID = "t2";
            Label lblSName2 = new Label();
            lblSName2.ID = "l2";
            lblSName2.Text = "Patient Id";
            tc2.Controls.Add(lblSName2);
            tr1.Controls.Add(tc2);
            tc3.ID = "t3";
            Label lblSName3 = new Label();
            lblSName3.ID = "l3";
            lblSName3.Text = "Patient Name";
            tc3.Controls.Add(lblSName3);
            tr1.Controls.Add(tc3);
            tc4.ID = "t4";
            Label lblSName4 = new Label();
            lblSName4.ID = "l4";
            lblSName4.Text = "Age";
            tc4.Controls.Add(lblSName4);
            tr1.Controls.Add(tc4);
            tc12.ID = "t12";
            Label lblSName12 = new Label();
            lblSName12.ID = "l12";
            lblSName12.Text = "Blood Pressure";
            tc12.Controls.Add(lblSName12);
            tr1.Controls.Add(tc12);
            tc13.ID = "t13";
            Label lblSName13 = new Label();
            lblSName13.ID = "l13";
            lblSName13.Text = "Pulse";
            tc13.Controls.Add(lblSName13);
            tr1.Controls.Add(tc13);
            tc14.ID = "t14";
            Label lblSName14 = new Label();
            lblSName14.ID = "l14";
            lblSName14.Text = "Respirations";
            tc14.Controls.Add(lblSName14);
            tr1.Controls.Add(tc14);
            tc15.ID = "t15";
            Label lblSName15 = new Label();
            lblSName15.ID = "l15";
            lblSName15.Text = "Temperature";
            tc15.Controls.Add(lblSName15);
            tr1.Controls.Add(tc15);
            tc16.ID = "t16";
            Label lblSName16 = new Label();
            lblSName16.ID = "l16";
            lblSName16.Text = "Description";
            tc16.Controls.Add(lblSName16);
            tr1.Controls.Add(tc16);
            tc5.ID = "t5";
            Label lblSName5 = new Label();
            lblSName5.ID = "l5";
            lblSName5.Text = "Result";
            tc5.Controls.Add(lblSName5);
            tr1.Controls.Add(tc5);
            tc6.ID = "t6";
            Label lblSName6 = new Label();
            lblSName6.ID = "l6";
            lblSName6.Text = "Doctor Id";
            tc6.Controls.Add(lblSName6);
            tr1.Controls.Add(tc6);
            tc7.ID = "t7";
            Label lblSName7 = new Label();
            lblSName7.ID = "l7";
            lblSName7.Text = "Doctor Name";
            tc7.Controls.Add(lblSName7);
            tr1.Controls.Add(tc7);
            tc8.ID = "t8";
            Label lblSName8 = new Label();
            lblSName8.ID = "l8";
            lblSName8.Text = "Pharmacy Id";
            tc8.Controls.Add(lblSName8);
            tr1.Controls.Add(tc8);
            tc9.ID = "t9";
            Label lblSName9 = new Label();
            lblSName9.ID = "l9";
            lblSName9.Text = "Checkup Date";
            tc9.Controls.Add(lblSName9);
            tr1.Controls.Add(tc9);
            tc10.ID = "t10";
            Label lblSName10 = new Label();
            lblSName10.ID = "l10";
            lblSName10.Text = "Checkup Time";
            tc10.Controls.Add(lblSName10);
            tr1.Controls.Add(tc10);
            tc11.ID = "t11";
            Label lblSName11 = new Label();
            lblSName11.ID = "l11";
            lblSName11.Text = "Prescription";
            tc11.Controls.Add(lblSName11);
            tr1.Controls.Add(tc11);
            t.Rows.Add(tr1);
            this.Panel1.Controls.Add(t);
           /* TableCell tc12;
            TableCell tc13;
            TableCell tc14;
            TableCell tc15;
            TableCell tc16;
            TableCell tc17;
            TableCell tc18;
            TableCell tc19;
            TableCell tc20;
            TableCell tc21;
            TableCell tc22;*/
            //Label lblSName;
            Label lblSw;
            SqlCommand cmd20 = new SqlCommand("select * from pdata7 where pid='" + Label14.Text + "'", cn);
            SqlDataAdapter da20 = new SqlDataAdapter(cmd20);
            DataSet ds20 = new DataSet();
            da20.Fill(ds20);
            int v1 = ds20.Tables[0].Rows.Count;
            if (ds20.Tables[0].Rows.Count > 0)
                for (int i = 0; i < v1; i++)
                {


                    TableRow tra = new TableRow();
                    tra.ID = "tra" + i.ToString();
                    tra.BorderColor = System.Drawing.Color.Blue;
                    //tra.Attributes.Add("style", "border: solid 3px Red");
                    TableCell tca1 = new TableCell();
                    tca1.ID = "tca1" + i.ToString();
                    Label lblS1 = new Label();
                    lblS1.ID = "LBLS1" + i.ToString();
                    lblS1.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                    tca1.Controls.Add(lblS1);
                    tra.Controls.Add(tca1);
                    TableCell tca2 = new TableCell();
                    tca2.ID = "tca2" + i.ToString();
                    Label lblS2 = new Label();
                    lblS2.ID = "LBLS2" + i.ToString();
                    lblS2.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(1).ToString();
                    tca2.Controls.Add(lblS2);
                    tra.Controls.Add(tca2);
                    TableCell tca3 = new TableCell();
                    tca3.ID = "tca3" + i.ToString();
                    Label lblS3 = new Label();
                    lblS3.ID = "LBLS3" + i.ToString();
                    lblS3.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(2).ToString();
                    tca3.Controls.Add(lblS3);
                    tra.Controls.Add(tca3);
                    TableCell tca4 = new TableCell();
                    tca4.ID = "tca4" + i.ToString();
                    Label lblS4 = new Label();
                    lblS4.ID = "LBLS4" + i.ToString();
                    lblS4.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(3).ToString();
                    tca4.Controls.Add(lblS4);
                    tra.Controls.Add(tca4);
                    TableCell tca12 = new TableCell();
                    tca12.ID = "tca12" + i.ToString();
                    Label lblS12 = new Label();
                    lblS12.ID = "LBLS12" + i.ToString();
                    string bp1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
                    string bp2 = enclass.decrypt1(bp1);
                    if (bp2.Equals("t"))
                    {
                        lblS12.Text = "Tampered";
                    }
                    else
                    {
                        lblS12.Text = bp2;
                    }
                    tca12.Controls.Add(lblS12);
                    tra.Controls.Add(tca12);
                    TableCell tca13 = new TableCell();
                    tca13.ID = "tca13" + i.ToString();
                    Label lblS13 = new Label();
                    lblS13.ID = "LBLS13" + i.ToString();
                    string pl1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(5).ToString();
                    string pl2 = enclass.decrypt1(pl1);
                    if (pl2.Equals("t"))
                    {
                        lblS13.Text = "Tampered";
                    }
                    else
                    {
                        lblS13.Text = pl2;
                    }
                    tca13.Controls.Add(lblS13);
                    tra.Controls.Add(tca13);
                    TableCell tca14 = new TableCell();
                    tca14.ID = "tca14" + i.ToString();
                    Label lblS14 = new Label();
                    lblS14.ID = "LBLS14" + i.ToString();
                    string rp1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(6).ToString();
                    string rp2 = enclass.decrypt1(rp1);
                    if (rp2.Equals("t"))
                    {
                        lblS14.Text = "Tampered";
                    }
                    else
                    {
                        lblS14.Text = rp2;
                    }
                    tca14.Controls.Add(lblS14);
                    tra.Controls.Add(tca14);
                    TableCell tca15 = new TableCell();
                    tca15.ID = "tca15" + i.ToString();
                    Label lblS15 = new Label();
                    lblS15.ID = "LBLS15" + i.ToString();
                    string tp1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(7).ToString();
                    string tp2 = enclass.decrypt1(tp1);
                    if (tp2.Equals("t"))
                    {
                        lblS15.Text = "Tampered";
                    }
                    else
                    {
                        lblS15.Text = tp2;
                    }
                    tca15.Controls.Add(lblS15);
                    tra.Controls.Add(tca15);
                    TableCell tca16 = new TableCell();
                    tca16.ID = "tca16" + i.ToString();
                    Label lblS16 = new Label();
                    lblS16.ID = "LBLS16" + i.ToString();
                    string desn1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(8).ToString();
                    string desn2 = enclass.decrypt1(desn1);
                    if (desn2.Equals("t"))
                    {
                        lblS16.Text = "Tampered";
                    }
                    else
                    {
                        lblS16.Text = desn2;
                    }
                    tca16.Controls.Add(lblS16);
                    tra.Controls.Add(tca16);
                    TableCell tca5 = new TableCell();
                    tca5.ID = "tca5" + i.ToString();
                    ImageButton lblS5 = new ImageButton();
                    lblS5.ID = "LBLS5" + i.ToString();
                    lblS5.Width = 100;
                    lblS5.Height = 100;
                    string ab = "1234512345678976";
                    // ab.GetBytes(secretkey);
                    byte[] secretkey = new Byte[64];
                    secretkey = ASCIIEncoding.UTF8.GetBytes(ab);
                    // Use the secret key to sign the message file.
                    //SignFile(secretkey, dataFile, signedFile);
                    // Verify the signed file

                    // @"D:\a1.txt";
                    string ft1;
                    ft1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(9).ToString();
                    string signedFile = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files1\" + ft1;
                    string encr = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files\" + ft1;
                    //string outc = ImageButton1.ImageUrl;
                    bool bl = enclass.VerifyFile(secretkey, signedFile,fl1);
                    if (bl)
                    {
                        lblS5.AlternateText = "tampered";
                    }
                    else
                    {
                        // string img1="";
                        //enclass.DecryptFile(encr, @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files3\" + fl1, "1234512345678976");

                        lblS5.ImageUrl = "Files3/" + ft1;
                        //System.IO.File.Delete(@"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\WebSite2\Files3\" + cc);
                    }


                    tca5.Controls.Add(lblS5);
                    tra.Controls.Add(tca5);
                    TableCell tca6 = new TableCell();
                    tca6.ID = "tca6" + i.ToString();
                    Label lblS6 = new Label();
                    lblS6.ID = "LBLS6" + i.ToString();
                    lblS6.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(10).ToString();
                    tca6.Controls.Add(lblS6);
                    tra.Controls.Add(tca6);
                    TableCell tca7 = new TableCell();
                    tca7.ID = "tca7" + i.ToString();
                    Label lblS7 = new Label();
                    lblS7.ID = "LBLS7" + i.ToString();
                    lblS7.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(11).ToString();
                    tca7.Controls.Add(lblS7);
                    tra.Controls.Add(tca7);
                    TableCell tca8 = new TableCell();
                    tca8.ID = "tca8" + i.ToString();
                    Label lblS8 = new Label();
                    lblS8.ID = "LBLS8" + i.ToString();
                    lblS8.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(12).ToString();
                    tca8.Controls.Add(lblS8);
                    tra.Controls.Add(tca8);
                    TableCell tca9 = new TableCell();
                    tca9.ID = "tca9" + i.ToString();
                    Label lblS9 = new Label();
                    lblS9.ID = "LBLS9" + i.ToString();
                    lblS9.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(13).ToString();
                    tca9.Controls.Add(lblS9);
                    tra.Controls.Add(tca9);
                    TableCell tca10 = new TableCell();
                    tca10.ID = "tca10" + i.ToString();
                    Label lblS10 = new Label();
                    lblS10.ID = "LBLS10" + i.ToString();
                    lblS10.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(14).ToString();
                    tca10.Controls.Add(lblS10);
                    tra.Controls.Add(tca10);
                    TableCell tca11 = new TableCell();
                    tca11.ID = "tca11" + i.ToString();
                    Label lblS11 = new Label();
                    lblS11.ID = "LBLS11" + i.ToString();
                    lblS11.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(15).ToString();
                    tca11.Controls.Add(lblS11);
                    tra.Controls.Add(tca11);
                    t.Rows.Add(tra);
                    this.Panel1.Controls.Add(t);
                }
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
            i = Convert.ToInt32(ViewState["n"].ToString());
            i++;
            ViewState["n"] = i;

            string a = Session["id"].ToString();
            cn.Open();
            SqlCommand com = new SqlCommand("select * from rfddata8 where did='" + a.ToString() + "' and fl='1'", cn);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if ((ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows.Count > i))
            {
                //Label20.Text = dn1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                Label46.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                Label20.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(1).ToString();
                Label22.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(2).ToString();
                Label24.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(3).ToString();
                Label26.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
                Label28.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(5).ToString();
                Label30.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(6).ToString();
                Label35.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(7).ToString();

                Label37.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(8).ToString();
                Label39.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(9).ToString();
                string bp3 = ds.Tables[0].Rows[i].ItemArray.GetValue(10).ToString();
                string bp4 = enclass.decrypt1(bp3);
                if (bp4.Equals("t"))
                {
                    Label59.Text = "Tampered";
                }
                else
                {
                    Label59.Text = bp4;
                }
                string pl3 = ds.Tables[0].Rows[i].ItemArray.GetValue(11).ToString();
                string pl4 = enclass.decrypt1(pl3);
                if (pl4.Equals("t"))
                {
                    Label61.Text = "Tampered";
                }
                else
                {
                    Label61.Text = pl4;
                }
                string rp3 = ds.Tables[0].Rows[i].ItemArray.GetValue(12).ToString();
                string rp4 = enclass.decrypt1(rp3);
                if (rp4.Equals("t"))
                {
                    Label63.Text = "Tampered";
                }
                else
                {
                    Label63.Text = rp4;
                }
                string tp3 = ds.Tables[0].Rows[i].ItemArray.GetValue(13).ToString();
                string tp4 = enclass.decrypt1(tp3);
                if (tp4.Equals("t"))
                {
                    Label65.Text = "Tampered";
                }
                else
                {
                    Label65.Text = tp4;
                }
                fl11 = ds.Tables[0].Rows[i].ItemArray.GetValue(14).ToString();
                OboutTextBox1.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(15).ToString();
                OboutTextBox3.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(16).ToString();



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
                string signedFile = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files1\" + fl11;
                string encr = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files\" + fl11;
                //string outc = ImageButton1.ImageUrl;
                bool bl = enclass.VerifyFile(secretkey, signedFile,fl1);
                if (bl)
                {
                    Label41.Text = "tampered";
                }
                else
                {
                    // string img1="";
                   // enclass.DecryptFile(encr, @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files3\" + fl11, "1234512345678976");

                    ImageButton1.ImageUrl = "Files3/" + fl11;
                    //System.IO.File.Delete(@"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\WebSite2\Files3\" + cc);
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
            string a = Session["id"].ToString();
            string ndes = OboutTextBox3.Text;

            SqlCommand cmc1 = new SqlCommand("select * from pinfo5 where id='" + Label26.Text + "'", cn);
            SqlDataAdapter dac1 = new SqlDataAdapter(cmc1);
            DataSet dsc1 = new DataSet();
            dac1.Fill(dsc1);
            if (dsc1.Tables[0].Rows.Count > 0)
            {
                addr1 = dsc1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                em1 = dsc1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                ct1 = dsc1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
            }
            cn.Open();
            SqlCommand ecmd4 = new SqlCommand("update rfddata8 set fl='2' where did='" + a + "' and pid='" + Label26.Text + "' and cid='" + Label24.Text + "' and fl='1'", cn);
            SqlCommand ecmd = new SqlCommand("update ddata7 set des='" + ndes + "' where did='" + a + "' and pid='" + Label26.Text + "' and cid='" + Label24.Text + "'", cn);
            SqlCommand ecmd2 = new SqlCommand("update pdata7 set des='" + ndes + "' where did='" + a + "' and pid='" + Label26.Text + "' and cid='" + Label24.Text + "'", cn);
            SqlCommand ecmd3 = new SqlCommand("insert into phdata7 values ('" + Label39.Text + "','" + a.ToString() + "','" + Label22.Text + "','" + ndes + "','" + Label26.Text + "','" + Label28.Text + "','" + addr1 + "','" + ct1 + "','" + em1 + "','0','"+Label24.Text+"')", cn);

            int num2 = ecmd2.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            int num3 = ecmd3.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            int num = ecmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            int num4 = ecmd4.ExecuteNonQuery();
            cn.Close();

            if (num > 0 && num2 > 0 && num3 > 0 && num4 > 0)
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
    protected void OboutButton3_Click(object sender, EventArgs e)
    {
        try
        {
            Table t = new Table();
            // t.Attributes.Add("BorderColor", "black");
            t.Attributes.Add("style", "border: solid 3px Red");

            TableRow tr1 = new TableRow();
            TableCell tc1 = new TableCell();
            TableCell tc2 = new TableCell();
            TableCell tc3 = new TableCell();
            TableCell tc4 = new TableCell();
            TableCell tc5 = new TableCell();
            TableCell tc6 = new TableCell();
            TableCell tc7 = new TableCell();
            TableCell tc8 = new TableCell();
            TableCell tc9 = new TableCell();
            TableCell tc10 = new TableCell();
            TableCell tc11 = new TableCell();
            TableCell tc12 = new TableCell();
            TableCell tc13 = new TableCell();
            TableCell tc14 = new TableCell();
            TableCell tc15 = new TableCell();
            TableCell tc16 = new TableCell();
            tc1.ID = "t1";
            Label lblSName1 = new Label();
            lblSName1.ID = "l1";
            lblSName1.Text = "Checkup Id";
            tc1.Controls.Add(lblSName1);
            tr1.Controls.Add(tc1);
            tc2.ID = "t2";
            Label lblSName2 = new Label();
            lblSName2.ID = "l2";
            lblSName2.Text = "Patient Id";
            tc2.Controls.Add(lblSName2);
            tr1.Controls.Add(tc2);
            tc3.ID = "t3";
            Label lblSName3 = new Label();
            lblSName3.ID = "l3";
            lblSName3.Text = "Patient Name";
            tc3.Controls.Add(lblSName3);
            tr1.Controls.Add(tc3);
            tc4.ID = "t4";
            Label lblSName4 = new Label();
            lblSName4.ID = "l4";
            lblSName4.Text = "Age";
            tc4.Controls.Add(lblSName4);
            tr1.Controls.Add(tc4);
            tc12.ID = "t12";
            Label lblSName12 = new Label();
            lblSName12.ID = "l12";
            lblSName12.Text = "Blood Pressure";
            tc12.Controls.Add(lblSName12);
            tr1.Controls.Add(tc12);
            tc13.ID = "t13";
            Label lblSName13 = new Label();
            lblSName13.ID = "l13";
            lblSName13.Text = "Pulse";
            tc13.Controls.Add(lblSName13);
            tr1.Controls.Add(tc13);
            tc14.ID = "t14";
            Label lblSName14 = new Label();
            lblSName14.ID = "l14";
            lblSName14.Text = "Respirations";
            tc14.Controls.Add(lblSName14);
            tr1.Controls.Add(tc14);
            tc15.ID = "t15";
            Label lblSName15 = new Label();
            lblSName15.ID = "l15";
            lblSName15.Text = "Temperature";
            tc15.Controls.Add(lblSName15);
            tr1.Controls.Add(tc15);
            tc16.ID = "t16";
            Label lblSName16 = new Label();
            lblSName16.ID = "l16";
            lblSName16.Text = "Description";
            tc16.Controls.Add(lblSName16);
            tr1.Controls.Add(tc16);
            tc5.ID = "t5";
            Label lblSName5 = new Label();
            lblSName5.ID = "l5";
            lblSName5.Text = "Result";
            tc5.Controls.Add(lblSName5);
            tr1.Controls.Add(tc5);
            tc6.ID = "t6";
            Label lblSName6 = new Label();
            lblSName6.ID = "l6";
            lblSName6.Text = "Doctor Id";
            tc6.Controls.Add(lblSName6);
            tr1.Controls.Add(tc6);
            tc7.ID = "t7";
            Label lblSName7 = new Label();
            lblSName7.ID = "l7";
            lblSName7.Text = "Doctor Name";
            tc7.Controls.Add(lblSName7);
            tr1.Controls.Add(tc7);
            tc8.ID = "t8";
            Label lblSName8 = new Label();
            lblSName8.ID = "l8";
            lblSName8.Text = "Pharmacy Id";
            tc8.Controls.Add(lblSName8);
            tr1.Controls.Add(tc8);
            tc9.ID = "t9";
            Label lblSName9 = new Label();
            lblSName9.ID = "l9";
            lblSName9.Text = "Checkup Date";
            tc9.Controls.Add(lblSName9);
            tr1.Controls.Add(tc9);
            tc10.ID = "t10";
            Label lblSName10 = new Label();
            lblSName10.ID = "l10";
            lblSName10.Text = "Checkup Time";
            tc10.Controls.Add(lblSName10);
            tr1.Controls.Add(tc10);
            tc11.ID = "t11";
            Label lblSName11 = new Label();
            lblSName11.ID = "l11";
            lblSName11.Text = "Prescription";
            tc11.Controls.Add(lblSName11);
            tr1.Controls.Add(tc11);
            t.Rows.Add(tr1);
            this.Panel1.Controls.Add(t);
           /* TableCell tc12;
            TableCell tc13;
            TableCell tc14;
            TableCell tc15;
            TableCell tc16;
            TableCell tc17;
            TableCell tc18;
            TableCell tc19;
            TableCell tc20;
            TableCell tc21;
            TableCell tc22;*/
            //Label lblSName;
            Label lblSw;
            SqlCommand cmd20 = new SqlCommand("select * from pdata7 where pid='" + Label26.Text + "'", cn);
            SqlDataAdapter da20 = new SqlDataAdapter(cmd20);
            DataSet ds20 = new DataSet();
            da20.Fill(ds20);
            int v1 = ds20.Tables[0].Rows.Count;
            if (ds20.Tables[0].Rows.Count > 0)
                for (int i = 0; i < v1; i++)
                {


                    TableRow tra = new TableRow();
                    tra.ID = "tra" + i.ToString();
                    tra.BorderColor = System.Drawing.Color.Blue;
                    //tra.Attributes.Add("style", "border: solid 3px Red");
                    TableCell tca1 = new TableCell();
                    tca1.ID = "tca1" + i.ToString();
                    Label lblS1 = new Label();
                    lblS1.ID = "LBLS1" + i.ToString();
                    lblS1.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                    tca1.Controls.Add(lblS1);
                    tra.Controls.Add(tca1);
                    TableCell tca2 = new TableCell();
                    tca2.ID = "tca2" + i.ToString();
                    Label lblS2 = new Label();
                    lblS2.ID = "LBLS2" + i.ToString();
                    lblS2.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(1).ToString();
                    tca2.Controls.Add(lblS2);
                    tra.Controls.Add(tca2);
                    TableCell tca3 = new TableCell();
                    tca3.ID = "tca3" + i.ToString();
                    Label lblS3 = new Label();
                    lblS3.ID = "LBLS3" + i.ToString();
                    lblS3.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(2).ToString();
                    tca3.Controls.Add(lblS3);
                    tra.Controls.Add(tca3);
                    TableCell tca4 = new TableCell();
                    tca4.ID = "tca4" + i.ToString();
                    Label lblS4 = new Label();
                    lblS4.ID = "LBLS4" + i.ToString();
                    lblS4.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(3).ToString();
                    tca4.Controls.Add(lblS4);
                    tra.Controls.Add(tca4);
                    TableCell tca12 = new TableCell();
                    tca12.ID = "tca12" + i.ToString();
                    Label lblS12 = new Label();
                    lblS12.ID = "LBLS12" + i.ToString();
                    string bp1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
                    string bp2 = enclass.decrypt1(bp1);
                    if (bp2.Equals("t"))
                    {
                        lblS12.Text = "Tampered";
                    }
                    else
                    {
                        lblS12.Text = bp2;
                    }
                    tca12.Controls.Add(lblS12);
                    tra.Controls.Add(tca12);
                    TableCell tca13 = new TableCell();
                    tca13.ID = "tca13" + i.ToString();
                    Label lblS13 = new Label();
                    lblS13.ID = "LBLS13" + i.ToString();
                    string pl1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(5).ToString();
                    string pl2 = enclass.decrypt1(pl1);
                    if (pl2.Equals("t"))
                    {
                        lblS13.Text = "Tampered";
                    }
                    else
                    {
                        lblS13.Text = pl2;
                    }
                    tca13.Controls.Add(lblS13);
                    tra.Controls.Add(tca13);
                    TableCell tca14 = new TableCell();
                    tca14.ID = "tca14" + i.ToString();
                    Label lblS14 = new Label();
                    lblS14.ID = "LBLS14" + i.ToString();
                    string rp1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(6).ToString();
                    string rp2 = enclass.decrypt1(rp1);
                    if (rp2.Equals("t"))
                    {
                        lblS14.Text = "Tampered";
                    }
                    else
                    {
                        lblS14.Text = rp2;
                    }
                    tca14.Controls.Add(lblS14);
                    tra.Controls.Add(tca14);
                    TableCell tca15 = new TableCell();
                    tca15.ID = "tca15" + i.ToString();
                    Label lblS15 = new Label();
                    lblS15.ID = "LBLS15" + i.ToString();
                    string tp1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(7).ToString();
                    string tp2 = enclass.decrypt1(tp1);
                    if (tp2.Equals("t"))
                    {
                        lblS15.Text = "Tampered";
                    }
                    else
                    {
                        lblS15.Text = tp2;
                    }
                    tca15.Controls.Add(lblS15);
                    tra.Controls.Add(tca15);
                    TableCell tca16 = new TableCell();
                    tca16.ID = "tca16" + i.ToString();
                    Label lblS16 = new Label();
                    lblS16.ID = "LBLS16" + i.ToString();
                    string desn1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(8).ToString();
                    string desn2 = enclass.decrypt1(desn1);
                    if (desn2.Equals("t"))
                    {
                        lblS16.Text = "Tampered";
                    }
                    else
                    {
                        lblS16.Text = desn2;
                    }
                    tca16.Controls.Add(lblS16);
                    tra.Controls.Add(tca16);
                    TableCell tca5 = new TableCell();
                    tca5.ID = "tca5" + i.ToString();
                    ImageButton lblS5 = new ImageButton();
                    lblS5.ID = "LBLS5" + i.ToString();
                    lblS5.Width = 100;
                    lblS5.Height = 100;
                    string ab = "1234512345678976";
                    // ab.GetBytes(secretkey);
                    byte[] secretkey = new Byte[64];
                    secretkey = ASCIIEncoding.UTF8.GetBytes(ab);
                    // Use the secret key to sign the message file.
                    //SignFile(secretkey, dataFile, signedFile);
                    // Verify the signed file

                    // @"D:\a1.txt";
                    string ft1;
                    ft1 = ds20.Tables[0].Rows[i].ItemArray.GetValue(9).ToString();
                    string signedFile = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files1\" + ft1;
                    string encr = @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files\" + ft1;
                    //string outc = ImageButton1.ImageUrl;
                    bool bl = enclass.VerifyFile(secretkey, signedFile,fl1);
                    if (bl)
                    {
                        lblS5.AlternateText = "tampered";
                    }
                    else
                    {
                        // string img1="";
                        //enclass.DecryptFile(encr, @"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files3\" + fl1, "1234512345678976");

                        lblS5.ImageUrl = "Files3/" + ft1;
                        //System.IO.File.Delete(@"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\WebSite2\Files3\" + cc);
                    }


                    tca5.Controls.Add(lblS5);
                    tra.Controls.Add(tca5);
                    TableCell tca6 = new TableCell();
                    tca6.ID = "tca6" + i.ToString();
                    Label lblS6 = new Label();
                    lblS6.ID = "LBLS6" + i.ToString();
                    lblS6.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(10).ToString();
                    tca6.Controls.Add(lblS6);
                    tra.Controls.Add(tca6);
                    TableCell tca7 = new TableCell();
                    tca7.ID = "tca7" + i.ToString();
                    Label lblS7 = new Label();
                    lblS7.ID = "LBLS7" + i.ToString();
                    lblS7.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(11).ToString();
                    tca7.Controls.Add(lblS7);
                    tra.Controls.Add(tca7);
                    TableCell tca8 = new TableCell();
                    tca8.ID = "tca8" + i.ToString();
                    Label lblS8 = new Label();
                    lblS8.ID = "LBLS8" + i.ToString();
                    lblS8.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(12).ToString();
                    tca8.Controls.Add(lblS8);
                    tra.Controls.Add(tca8);
                    TableCell tca9 = new TableCell();
                    tca9.ID = "tca9" + i.ToString();
                    Label lblS9 = new Label();
                    lblS9.ID = "LBLS9" + i.ToString();
                    lblS9.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(13).ToString();
                    tca9.Controls.Add(lblS9);
                    tra.Controls.Add(tca9);
                    TableCell tca10 = new TableCell();
                    tca10.ID = "tca10" + i.ToString();
                    Label lblS10 = new Label();
                    lblS10.ID = "LBLS10" + i.ToString();
                    lblS10.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(14).ToString();
                    tca10.Controls.Add(lblS10);
                    tra.Controls.Add(tca10);
                    TableCell tca11 = new TableCell();
                    tca11.ID = "tca11" + i.ToString();
                    Label lblS11 = new Label();
                    lblS11.ID = "LBLS11" + i.ToString();
                    lblS11.Text = ds20.Tables[0].Rows[i].ItemArray.GetValue(15).ToString();
                    tca11.Controls.Add(lblS11);
                    tra.Controls.Add(tca11);
                    t.Rows.Add(tra);
                    this.Panel1.Controls.Add(t);
                }
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            Response.Redirect(ImageButton1.ImageUrl);
        }
        catch (Exception e1)
        {

            Response.Write("<script> alert(" + e1.Message + ")</script>");
        }
    }
    protected void OboutButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("DoctorHome.aspx");
    }
}