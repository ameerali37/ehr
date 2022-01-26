<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LaboratoryHome.aspx.cs" Inherits="LaboratoryHome" %>
<%@ Register TagPrefix="obout" Namespace="Obout.Interface" Assembly="obout_Interface" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .style1
        {
            width: 387px;
        }
        .style2
        {
            width: 261px;
        }
        .style3
        {
            width: 180px;
        }
         .bg1
        {
            width:300px;
	float:left;
	margin-left:50px;
	border-radius:10px;
            background-color:#A23BEC;
        }
           .bg2
        {
            width:400px;
	float:left;
	margin-left:50px;
	border-radius:10px;
            background-color:#BCC6CC;
        }
        </style>
    <link href="style/stylesheet.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>

    <tr>
    <td align="center" class="style2">
    <div class="bg1">
    <h4>
                            Personal Information
                            </h4>
                        <br />
<table class="style3" border="white" style="font-weight: bold">

<tr>
<td>
    <asp:Label ID="Label19" runat="server" Text="Id:"></asp:Label>
</td><td>
        <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label21" runat="server" Text="Name:"></asp:Label>
</td><td>
        <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label23" runat="server" Text="Address:"></asp:Label>
</td><td>
        <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label25" runat="server" Text="E mail:"></asp:Label>
</td><td>
        <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label27" runat="server" Text="Contact No:"></asp:Label>
</td><td>
        <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
    </td></tr></table></div></td>

   
     <td align="center" class="style1">
<div class="bg2">
                        <h4>
                            Submit the Result here..>
                            </h4>
                        <br />
                        <table width="300" cellspacing="15">
                            <tr>
                                <td align="right" class="color">
                                    &nbsp;<asp:Label ID="Label29" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Checkup Id:"></asp:Label>
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="txt1" Width="165" Text="Some text" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Patient Id:"></asp:Label>
&nbsp;</td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="pn" Width="165" Text="Some text" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label31" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Blood Pressure:"></asp:Label>
&nbsp;</td>
                                <td class="style1" align="justify">
                                    <obout:OboutTextBox runat="server" ID="OboutTextBox5" Width="70px" 
                                        Text="Some text" />
                                        
                                    <asp:Label ID="Label38" runat="server" Font-Bold="True" Text="/"></asp:Label>
                                    <obout:OboutTextBox runat="server" ID="OboutTextBox1" Width="70px" 
                                        Text="Some text" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label32" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Pulse:"></asp:Label>
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="OboutTextBox2" Width="165" Text="Some text" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label33" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Respirations:"></asp:Label>
&nbsp;</td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="OboutTextBox3" Width="165" Text="Some text" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label34" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Temperature:"></asp:Label>
&nbsp;</td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="OboutTextBox4" Width="165" Text="Some text" />
                                </td>
                            </tr>
                            
                             <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Description:"></asp:Label>
&nbsp;</td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="OboutTextBox6" Width="165" 
                                        Text="Some text" TextMode="MultiLine" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Report:"></asp:Label>
                                </td>
                                <td class="style1">
                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label36" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Doctor Id:"></asp:Label>
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="ct" Width="165" Text="Some text" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    <asp:Label ID="Label37" runat="server" Font-Bold="True" ForeColor="Black" 
                                        Text="Pharmacy Id:"></asp:Label>
&nbsp;</td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="un" Width="165" Text="Some text" />
                                </td>
                            </tr>
                           
                            <tr>
                                <td  colspan="2" align="center">
                                    <obout:OboutButton runat="server" ID="btn1" Width="165" Text="Submit" onclick="btn1_Click" 
                                        />
                                        <obout:OboutButton runat="server" ID="Button1" Width="165" Text="Logout" onclick="Button1_Click" 
                                        />
                                </td>
                            </tr>
                        </table></td><td ><table><tr><td>
                         <obout:OboutButton runat="server" ID="OboutButton1" Width="165" Text="Validate Patient" onclick="OboutButton1_Click" 
                                        /></td></tr>
                                       <tr><td>
             <obout:OboutButton runat="server" ID="OboutButton2" Width="165" Text="Validate Doctor" onclick="OboutButton2_Click" 
                                        /></td></tr>
                                        <tr>
                                        <td>
                                        <obout:OboutButton runat="server" ID="OboutButton3" Width="165" Text="Validate Pharmacy" onclick="OboutButton3_Click" 
                                        />
                                        </td></tr></table>
        </td><td>
        <table class="style3" border="white" style="font-weight: bold">
        <tr>
<td>
    
    <asp:Image ID="Image2" runat="server" Height="105px" Visible="False" 
        Width="105px" />
    
</td><td>
       
    </td></tr>

<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Id:" Visible="False"></asp:Label>
</td><td>
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label3" runat="server" Text="Name:" Visible="False"></asp:Label>
</td><td>
        <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
    </td></tr>
    <tr>
<td>
    <asp:Label ID="Label11" runat="server" Text="Specialization:" Visible="False"></asp:Label>
</td><td>
        <asp:Label ID="Label12" runat="server" Text="Label" Visible="False"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label5" runat="server" Text="Address:" Visible="False"></asp:Label>
</td><td>
        <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label7" runat="server" Text="E mail:" Visible="False"></asp:Label>
</td><td>
        <asp:Label ID="Label8" runat="server" Text="Label" Visible="False"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label9" runat="server" Text="Contact No:" Visible="False"></asp:Label>
</td><td>
        <asp:Label ID="Label10" runat="server" Text="Label" Visible="False"></asp:Label>
    </td></tr></table></td></tr> 
                   </table>

</asp:Content>

