<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="prac4_1.Registration" MasterPageFile="~/MasterPage.master" %>


   <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
     <h1 style="text-align: center">Techstorm Registration Form</h1>
            <br />
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">First Name</td>
                    <td class="auto-style5" style="text-align: left">
                        <asp:TextBox ID="txtFN" runat="server" Width="118px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFN" ErrorMessage="First Name is Empty" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Last Name</td>
                    <td class="auto-style5" style="text-align: left">
                        <asp:TextBox ID="txtLN" runat="server" Width="118px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLN" ErrorMessage="Last Name is Empty" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Email ID</td>
                    <td class="auto-style1" style="text-align: left">
                        <asp:TextBox ID="txtEMAIL" runat="server" Width="118px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEMAIL" ErrorMessage="Email Id is Empty" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEMAIL" ErrorMessage="VESIT Email Only" ForeColor="Yellow" SetFocusOnError="True" ValidationExpression="^[A-Za-z0-9._%+-]+@ves\.ac\.in$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td class="auto-style5" style="text-align: left">
                        <asp:TextBox ID="txtP" runat="server" Width="118px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtP" ErrorMessage="Password is blank" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Re-Type Password</td>
                    <td class="auto-style7" style="text-align: left">
                        <asp:TextBox ID="txtRTP" runat="server" Width="118px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtRTP" ErrorMessage="Retype Pwd is blank" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtP" ControlToValidate="txtRTP" ErrorMessage="Password does not match" ForeColor="Yellow"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Class</td>
                  
   <td align ="Left" dir="ltr" class="auto-style5"> <asp:RadioButtonList ID="rbl" runat="server" >
       <asp:ListItem>FYMCA_A</asp:ListItem>
       <asp:ListItem>FYMCA_B</asp:ListItem>
       <asp:ListItem>SYMCA_A</asp:ListItem>
       <asp:ListItem>SYMCA_B</asp:ListItem>
                        </asp:RadioButtonList>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="rbl" ErrorMessage="Please Select Your Class" ForeColor="Red"></asp:RequiredFieldValidator>
                       <br />
                       
                    <br />
                       
                       
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Events</td>
                    <td class="auto-style5" align="Left" dir="ltr">
                        
                        
                        <asp:CheckBoxList ID="cb" runat="server">
                            <asp:ListItem>AWT_QUIZ</asp:ListItem>
                            <asp:ListItem>JAVA_QUIZ</asp:ListItem>
                            <asp:ListItem>IOT_QUIZ</asp:ListItem>
                            <asp:ListItem>CASE_STUDY</asp:ListItem>
                        </asp:CheckBoxList>
                        &nbsp;<br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Age</td>
                    <td class="auto-style5" style="text-align: left">
                        <asp:TextBox ID="txtAGE" runat="server" Width="113px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Enter Age" ControlToValidate="txtAGE" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAGE" ErrorMessage="Age Must be between 18-30" ForeColor="Yellow" MaximumValue="30" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" dir="ltr">Mobile No</td>
                    <td class="auto-style5" style="text-align: left">
                        <asp:TextBox ID="txtMN" runat="server" Width="118px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Enter Mobile No" ControlToValidate="txtMN" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtMN" ErrorMessage="Invalid Number Min10 digits" ForeColor="Yellow" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">User Id</td>
                    <td class="auto-style5" style="text-align: left">
                        <asp:TextBox ID="txtUI" runat="server" Width="113px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Enter User Id" ControlToValidate="txtUI" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;
                         </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4" style="text-align: left">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5" style="text-align: left">
                        <asp:Button ID="Button1" runat="server" Text="Register Now" Width="156px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4" style="text-align: left" rowspan="3">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Form is Incomplete, Please fill all the details properly." />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
            <br />

   </asp:Content>
