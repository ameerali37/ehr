<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LaboratoryRegister.aspx.cs" Inherits="LaboratoryRegister" %>
<%@ Register TagPrefix="obout" Namespace="Obout.Interface" Assembly="obout_Interface" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="style/stylesheet.css" rel="stylesheet" type="text/css" />
 <style type="text/css">
        *
        {
            margin: 0px;
            padding: 0px;
        }
         .bg1
        {
            width:300px;
	float:left;
	margin-left:50px;
	border-radius:10px;
            background-color:#06C;
        }
        .background
        {
            background-color: Black;
        }
        
        h2
        {
            color: Blue;
            margin-left: 20px;
        }
        
        p
        {
            font-family: Verdana;
            font-size: 12px;
            text-align: justify;
            line-height: 25px;
            margin-left: 20px;
        }
        h4
        {
            color: White;
            font-family: Verdana;
            font-weight: bold;
            margin-left: 70px;
            font-size: larger;
        }
          .bg1
        {
            width:300px;
	float:left;
	margin-left:50px;
	border-radius:10px;
            background-color:#A23BEC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
            <tr><td width="600px" valign="top">
                <table>
                    <tr>
                        <td>
                            <h2>
                                Welcome...<br />
                            </h2>
                            <p>
                                <b><span>H</span></b><span>EALTHCARE ecosystem consists of healthcare providers, 
                                payers, pharmaceutical companies, IT solutions and services firms, and the 
                                patients.<o:p> The healthcare providers are doctors, physicians, specialists, 
                                etc. And payers can be health insurance companies. When a patient is admitted to 
                                a hospital, his/her information is entered into electronic health record&nbsp; 
                                systems. Physicians diagnose the patient and the diagnostic information (from 
                                medical devices such as CT scanners, MRI scanners, etc.) is stored in EHR 
                                systems. In the diagnosis process, the doctors retrieve the health information 
                                of patients and analyze it to diagnose the illness. Doctors can take expert 
                                advice by sharing the information with consulting specialists.</o:p></span> The 
                                cloud can provide several benefits to all the stakeholders in the healthcare 
                                ecosystem through systems such as health information management system, 
                                laboratory information system, radiology information system, pharmacy 
                                information system, etc.
                            </p>
                        </td>
                    </tr>
                </table>
            </td>
                <td>
                    <div class="bg1">
                        <h4>
                            Create New Account</h4>
                        <br />
                        <table width="300" cellspacing="15">
                            <tr>
                                <td align="right" class="color">
                                    Laboratory Id:
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="txt1" Width="165"   />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    Laboratory Name:
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="ln" Width="165"   />
                                </td>
                            </tr>
                            
                            <tr>
                                <td align="right" class="color">
                                    Address:
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="ad" Width="165" Height="90" 
                                        TextMode="MultiLine"   />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    Email:
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="em" Width="165"   />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    Contact No:
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="ct" Width="165"   />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    Username:
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="un" Width="165"   />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="color">
                                    Password:
                                </td>
                                <td class="style1">
                                    <obout:OboutTextBox runat="server" ID="pw" Width="165" TextMode="Password"   />
                                </td>
                            </tr>
                            <tr>
                                <td  colspan="2" align="center">
                                    <obout:OboutButton runat="server" ID="btn1" Width="165" Text="Register" 
                                        onclick="btn1_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
</asp:Content>

