<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>
<%@ Register TagPrefix="oem" Namespace="OboutInc.EasyMenu_Pro" Assembly="obout_EasyMenu_Pro" %>
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
            background-color:#A23BEC;
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
        body 
			{
			    font-family: Verdana; 
			    font-size: XX-Small; 
			    margin: 0px; 
			    padding: 20px
			}
			.title 
			{
			    font-size: X-Large; 
			    padding: 20px; 
			    border-bottom: 2px solid gray;
			}
			.tdText {
                font:11px Verdana;
                color:#333333;
            }
       
    </style>
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="100%">
<tr>
<td align="center">







 <oem:EasyMenu id="EasymenuMain" runat="server" ShowEvent="Always" StyleFolder="styles/horizontal8"
		        Position="Horizontal" CSSMenu="ParentMenu" 
        CSSMenuItemContainer="ParentItemContainer" Width="430" 
        style="position: relative">
		        <CSSClassesCollection>
			        <oem:CSSClasses ObjectType="OboutInc.EasyMenu_Pro.MenuItem" ComponentSubMenuCellOver="ParentItemSubMenuCellOver"
				        ComponentContentCell="ParentItemContentCell" Component="ParentItem" ComponentSubMenuCell="ParentItemSubMenuCell"
				        ComponentIconCellOver="ParentItemIconCellOver" ComponentIconCell="ParentItemIconCell"
				        ComponentOver="ParentItemOver" ComponentContentCellOver="ParentItemContentCellOver"></oem:CSSClasses>
			        <oem:CSSClasses ObjectType="OboutInc.EasyMenu_Pro.MenuSeparator" ComponentSubMenuCellOver="ParentSeparatorSubMenuCellOver"
				        ComponentContentCell="ParentSeparatorContentCell" Component="ParentSeparator"
				        ComponentSubMenuCell="ParentSeparatorSubMenuCell" ComponentIconCellOver="ParentSeparatorIconCellOver"
				        ComponentIconCell="ParentSeparatorIconCell" ComponentOver="ParentSeparatorOver"
				        ComponentContentCellOver="ParentSeparatorContentCellOver"></oem:CSSClasses>
		        </CSSClassesCollection>
		        <Components>
			        <oem:MenuItem InnerHtml="Doctor" ID="item1" Url="DoctorRegister.aspx"></oem:MenuItem>
			        <oem:MenuSeparator InnerHtml="&nbsp;&nbsp;" ID="mainMenuSeparator1"></oem:MenuSeparator>
			        <oem:MenuItem InnerHtml="Patient" ID="item2" Url="PatientRegister.aspx"></oem:MenuItem>
			        <oem:MenuSeparator InnerHtml="&nbsp;" ID="mainMenuSeparator2"></oem:MenuSeparator>
			        <oem:MenuItem InnerHtml="Laboratory" ID="item3" Url="LaboratoryRegister.aspx"></oem:MenuItem>
			        <oem:MenuSeparator InnerHtml="&nbsp;" ID="mainMenuSeparator3"></oem:MenuSeparator>
			        <oem:MenuItem InnerHtml="Pharmacy" ID="item4" Url="PharmacyRegister.aspx"></oem:MenuItem>
		        </Components>
	        </oem:EasyMenu>
        	
	        <!--// The menus //-->
	       
	        

</td></tr></table>
<br />
<br />
<br />
<br />
<br />
<br />

  <table width="1024px" height="450">
        <tr>
            <td width="600px" valign="top">
                <table>
                    <tr>
                        <td>
                            <h2>
                                Welcome...<br />
                            </h2>
                            <p class="MsoNormal">
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
                                information system, etc.</p>
                            <p>
                                &nbsp;</p>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="400px">
                <div class="bg1">
                   
                    <h3>
                        Login</h3>
                    <br />
                    <table width="300" cellspacing="10">
                        <tr>
                            <td align="right" class="color">
                                User Name
                            </td>
                            <td>                                    <obout:OboutTextBox runat="server" 
                                    ID="txt1" Width="165" 
                                         />
                                
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="color">
                                Password
                            </td>
                            <td>                                    <obout:OboutTextBox runat="server" 
                                    ID="txt2" Width="165" Text="Some text" TextMode="Password" 
                                         />
                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center"><obout:OboutButton runat="server" ID="btn1" Width="165" Text="Login" 
                                        onclick="btn1_Click" />
                            </td>
                           
                        </tr>
                    </table>
                   
                </div>
                <!--end of login-->
            </td>
        </tr>
    </table>
<br />
<br />
<br />
<br />
</asp:Content>

