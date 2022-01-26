<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Refer.aspx.cs" Inherits="Refer" %>
<%@ Register TagPrefix="obout" Namespace="Obout.Interface" Assembly="obout_Interface" %>
<%@ Register assembly="obout_Grid_NET" namespace="Obout.Grid" tagprefix="cc1" %>
<%@ Register assembly="Obout.Ajax.UI" namespace="Obout.Ajax.UI.ColorPicker" tagprefix="obout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .style1
        {
            width: 387px;
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
<tr>
<td align="center" class="style1">
<div class="bg2">

<h4>
                            Referred To You...
                            </h4>
            &nbsp;
            <table>
             <tr>
            <td>
                <asp:Label ID="Label43" runat="server" Text="Refer Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label44" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                </td></tr>
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
                <asp:Label ID="Label49" runat="server" Text="Blood Pressure:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label50" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label51" runat="server" Text="Pulse:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label52" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label53" runat="server" Text="Respirations:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label54" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label55" runat="server" Text="Temperature:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label56" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 
             <tr>
            <td>
                <asp:Label ID="Label58" runat="server" Text="Report:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="69px" 
                    onclick="ImageButton2_Click" Width="76px" />
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
                <asp:Label ID="Label9" runat="server" Text="Description:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <obout:OboutTextBox runat="server" ID="TextBox1" Width="165" Height="90" 
                                        TextMode="MultiLine" Text="Some text" />
                 </td></tr>
                  <tr>
            <td>
                <asp:Label ID="Label47" runat="server" Text="Prescription:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <obout:OboutTextBox runat="server" ID="OboutTextBox2" Width="165" Height="90" 
                                        TextMode="MultiLine" Text="Some text" />
                 </td></tr>
             <tr>
            <td align="center">
                <obout:OboutButton runat="server" ID="Button1" Width="130" Text="Next
                 " onclick="Button1_Click" Font-Bold="True" 
                                        />
            </td>
            <td align="center">
                 <obout:OboutButton runat="server" ID="Button2" Width="130" Text="Submit
                 " onclick="Button2_Click" Font-Bold="True" 
                                        />
                 </td></tr></table></div>
</td>
<td class="style4">
                 <obout:OboutButton runat="server" ID="Button6" Width="130" Text="View History
                 " onclick="Button6_Click" Font-Bold="True" 
                                        />
<td align="center" class="style1">
<div class="bg2">

<h4>
                            Result of Your Reference...
                            </h4>
            &nbsp;
            <table>
             <tr>
            <td>
                <asp:Label ID="Label45" runat="server" Text="Refer Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label46" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                </td></tr>
            <tr>
            <td>
                <asp:Label ID="Label19" runat="server" Text="Doctor Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label20" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label21" runat="server" Text="Doctor Name" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label22" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label23" runat="server" Text="Checkup Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label24" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label25" runat="server" Text="Patient Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label26" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label27" runat="server" Text="Patient Name:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label28" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                  <tr>
            <td>
                <asp:Label ID="Label29" runat="server" Text="Age:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label30" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label34" runat="server" Text="Checkup Date" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label35" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             <tr>
            <td>
                <asp:Label ID="Label36" runat="server" Text="Checkup Time:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label37" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                  <tr>
             <td align="center">
             <div class="bg3">
             <table>
             <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Blood Pressure:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label59" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label60" runat="server" Text="Pulse:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label61" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label62" runat="server" Text="Respirations:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label63" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 <tr>
            <td>
                <asp:Label ID="Label64" runat="server" Text="Temperature:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label65" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
                 
             <tr>
            <td>
                <asp:Label ID="Label67" runat="server" Text="Report:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="69px" 
                    onclick="ImageButton1_Click" Width="76px" />
                 <asp:Label ID="Label41" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr></table>
                 </div></td><td></td></tr>
             <tr>
            <td>
                <asp:Label ID="Label38" runat="server" Text="Pharmacy Id:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label39" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                 </td></tr>
             
             <tr>
            <td>
                <asp:Label ID="Label40" runat="server" Text="Result:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td></tr>
             <tr>
            <td>
                <asp:Label ID="Label42" runat="server" Text="Description:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <obout:OboutTextBox runat="server" ID="OboutTextBox1" Width="165" Height="90" 
                                        TextMode="MultiLine" Text="Some text" />
                 </td></tr>
                  <tr>
            <td>
                <asp:Label ID="Label48" runat="server" Text="Prescription:" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <obout:OboutTextBox runat="server" ID="OboutTextBox3" Width="165" Height="90" 
                                        TextMode="MultiLine" Text="Some text" />
                 </td></tr>
             <tr>
            <td align="center">
                <obout:OboutButton runat="server" ID="OboutButton1" Width="130" Text="Next
                 " onclick="OboutButton1_Click" Font-Bold="True" 
                                        />
            </td>
            <td align="center">
                 <obout:OboutButton runat="server" ID="OboutButton2" Width="130" Text="Submit
                 " onclick="OboutButton2_Click" Font-Bold="True" 
                                        />
                 </td></tr></table></div>
</td>
<td class="style4">
<obout:OboutButton runat="server" ID="OboutButton4" Width="130" Text="Home
                 " onclick="OboutButton4_Click" Font-Bold="True" style="top: 1px; left: 0px" 
                                        />
                 <obout:OboutButton runat="server" ID="OboutButton3" Width="130" Text="View History
                 " onclick="OboutButton3_Click" Font-Bold="True" 
                                        />
                                        </td>
                                        <td align="justify" class="style5">
        <asp:Panel ID="Panel1" runat="server" 
            
            style="position: relative; top: -10px; left: 10px; height: 189px; width: 318px">
        </asp:Panel>
        
        </td>
</tr>
</table>
</asp:Content>

