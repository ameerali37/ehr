<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DoctorHome.aspx.cs" Inherits="DoctorHome" %>
<%@ Register TagPrefix="obout" Namespace="Obout.Interface" Assembly="obout_Interface" %>
<%@ Register assembly="obout_Grid_NET" namespace="Obout.Grid" tagprefix="cc1" %>
<%@ Register assembly="Obout.Ajax.UI" namespace="Obout.Ajax.UI.ColorPicker" tagprefix="obout" %>

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
        .style4
        {
            width: 125px;
        }
        .style5
        {
            width: 342px;
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
            width:450px;
	float:left;
	margin-left:50px;
	border-radius:10px;
            background-color:#BCC6CC;
        }
           .bg3
        {
           border-radius:10px;
            background-color:#EE82EE;
        }
        .style6
        {
            width: 280px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
<tr>
<td align="center" class="style2"><div class="bg1">
<h4>
                            Personal Information
                        </h4><br />
<table class="style3" style="font-weight: bold">
<tr>
<td>
    <asp:Image ID="Image2" runat="server" Height="105px" Width="105px" />
</td><td></td></tr>
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
    <asp:Label ID="Label23" runat="server" Text="Specialization:"></asp:Label>
</td><td>
        <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label25" runat="server" Text="Address:"></asp:Label>
</td><td>
        <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label27" runat="server" Text="E mail:"></asp:Label>
</td><td>
        <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label29" runat="server" Text="Contact No:"></asp:Label>
</td><td>
        <asp:Label ID="Label30" runat="server" Text="Label"></asp:Label>
    </td></tr></table>

<br />
    <br /></div>
		</td>
        <td align="center" class="style1"><div class="bg2">


            &nbsp;
            <table>
            <tr>
            <td class="style6">
                <asp:Label ID="Label1" runat="server" Text="Doctor Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                </td></tr>
             <tr>
            <td class="style6">
                <asp:Label ID="Label2" runat="server" Text="Doctor Name" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td class="style6">
                <asp:Label ID="Label3" runat="server" Text="Checkup Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td class="style6">
                <asp:Label ID="Label4" runat="server" Text="Patient Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td class="style6">
                <asp:Label ID="Label5" runat="server" Text="Patient Name:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                  <tr>
            <td class="style6">
                <asp:Label ID="Label17" runat="server" Text="Age:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label32" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td class="style6">
                <asp:Label ID="Label6" runat="server" Text="Checkup Date" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td class="style6">
                <asp:Label ID="Label7" runat="server" Text="Checkup Time:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label31" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             
             <tr>
             <td align="center" class="style6">
             <div class="bg3">
             <table>
             <tr>
            <td>
                <asp:Label ID="Label35" runat="server" Text="Blood Pressure:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label36" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label37" runat="server" Text="Pulse:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label38" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label39" runat="server" Text="Respirations:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label40" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label41" runat="server" Text="Temperature:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label42" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                  <tr>
            <td>
                <asp:Label ID="Label43" runat="server" Text="Description:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <obout:OboutTextBox runat="server" ID="TextBox2" Height="90" 
                                        TextMode="MultiLine" Text="Some text" 
                    style="top: 0px; left: 0px; width: 126px" />
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Report:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="69px" 
                    onclick="ImageButton1_Click" Width="76px" />
                 <asp:Label ID="Label33" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr></table>
                 </div></td><td></td></tr>
             <tr>
            <td class="style6">
                <asp:Label ID="Label9" runat="server" Text="Prescription:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <obout:OboutTextBox runat="server" ID="TextBox1" Width="165" Height="90" 
                                        TextMode="MultiLine" Text="Some text" />
                 </td></tr>
                 <tr>
            <td class="style6">
                <asp:Label ID="Label8" runat="server" Text="Pharmacy Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td align="center" class="style6">
                <obout:OboutButton runat="server" ID="Button1" Width="130" Text="Next
                 " onclick="Button1_Click" Font-Bold="True" 
                                        />
            </td>
            <td align="center">
                 <obout:OboutButton runat="server" ID="Button2" Width="130" Text="Submit
                 " onclick="Button2_Click" Font-Bold="True" 
                                        />
                 </td></tr></table></div></td><td class="style4">
                 <obout:OboutButton runat="server" ID="OboutButton2" Width="130" Text="View Reference
                 " onclick="OboutButton2_Click" Font-Bold="True" 
                                        />
                 <obout:OboutButton runat="server" ID="Button6" Width="130" Text="Refer To
                 " onclick="Button6_Click" Font-Bold="True" 
                                        />
                                        
                <asp:Label ID="Label34" runat="server" Text="Doctor Id:" Font-Bold="True" 
                     Visible="False"></asp:Label>
                                        <obout:OboutTextBox runat="server" ID="txt1" Width="130" 
                     Text="Some text" Visible="False" />
                                        <obout:OboutButton runat="server" ID="OboutButton1" 
                     Width="130" Text="Submit             " onclick="OboutButton1_Click" Font-Bold="True" Visible="False" 
                                        />
         <obout:OboutButton runat="server" ID="Button5" Width="130" Text="Logout
                 " onclick="Button5_Click" Font-Bold="True" 
                                        />
        <obout:OboutButton runat="server" ID="Button4" Width="130" Text="View History
                 " onclick="Button4_Click" Font-Bold="True" 
                                        />
        
        </td><td align="justify" class="style5">
        <asp:Panel ID="Panel1" runat="server" 
            
            style="position: relative; top: -10px; left: 10px; height: 189px; width: 318px">
        </asp:Panel>
        
        </td></tr></table>
		
</asp:Content>

