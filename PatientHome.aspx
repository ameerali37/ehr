<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PatientHome.aspx.cs" Inherits="PatientHome" %>
<%@ Register TagPrefix="obout" Namespace="Obout.Interface" Assembly="obout_Interface" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 632px;
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
    <asp:Image ID="Image2" runat="server" Width="104px" />
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
    </td></tr>
<tr>
<td>
    <asp:Label ID="Label29" runat="server" Text="Date of Birth:"></asp:Label>
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
            <td>
                <asp:Label ID="Label1" runat="server" Text="Doctor Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Doctor Name" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Checkup Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Patient Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Patient Name:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                  <tr>
            <td>
                <asp:Label ID="Label17" runat="server" Text="Age:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label32" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Checkup Date" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Checkup Time:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label31" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
             <td align="center">
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
                <obout:OboutTextBox runat="server" ID="TextBox2" Width="165" Height="90" 
                                        TextMode="MultiLine" Text="Some text" />
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label34" runat="server" Text="Report:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="61px" 
                    onclick="ImageButton1_Click" Width="66px" />
                 <asp:Label ID="Label33" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr></table>
                 </div></td><td></td></tr>
             <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Pharmacy Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             
             
             <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Prescription:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <obout:OboutTextBox runat="server" ID="TextBox1" Width="165" Height="90" 
                                        TextMode="MultiLine" Text="Some text" />
                 </td></tr>
             <tr>
            <td>
                <obout:OboutButton runat="server" ID="Button1" Width="165" Text="Next" onclick="Button1_Click" 
                                        />
            </td>
            <td>
               <obout:OboutButton runat="server" ID="Button5" Width="165" Text="Logout" onclick="Button5_Click" 
                                        />
                 </td></tr></table></div></td></tr></table>
    </asp:Content>

