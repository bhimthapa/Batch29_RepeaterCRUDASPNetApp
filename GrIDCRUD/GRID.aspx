<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GRID.aspx.cs" Inherits="GrIDCRUD.GRID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" OnItemDataBound="Repeater1_ItemDataBound">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <td>EmployeeId</td>
                            <td>FirstName</td>
                              <td>LastName</td>
                            <td>Salary</td>
                              <td>Address</td>
                            <td>PhoneNo</td>
                        </tr>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtEmploymentId" ReadOnly="true" Text='<%# Bind("EmploymentId")%>' runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFirstName" ReadOnly="true" Text='<%# Bind("FirstName")%>' runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="txtFirstName" ID="RequiredFieldValidator1" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                             </td>
                        <td>
                            <asp:TextBox ID="txtLastName" ReadOnly="true" Text='<%# Bind("LastName")%>' runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ControlToValidate="txtLastName" ID="RequiredFieldValidator2" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSalary" ReadOnly="true" Text='<%# Bind("Salary")%>' runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ControlToValidate="txtSalary" ID="RequiredFieldValidator3" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAddress" ReadOnly="true" Text='<%# Bind("Address")%>' runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ControlToValidate="txtAddress" ID="RequiredFieldValidator4" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPhoneNo" ReadOnly="true" Text='<%# Bind("PhoneNo")%>' runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ControlToValidate="txtPhoneNo" ID="RequiredFieldValidator5" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:LinkButton CausesValidation="false" CommandName="Select" ID="btnSelect" Text="Select"  runat="server"></asp:LinkButton>
                            <asp:LinkButton CausesValidation="false" CommandName="Update" Visible="false"  ID="btnUpdate" Text="Update" OnClientClick="return confirm('Are you sure to Update?');"  runat="server"></asp:LinkButton>
                            <asp:LinkButton CausesValidation="false" CommandName="Delete" Visible="false" ID="btnDelete" Text="Delete"  OnClientClick="return confirm('Are you sure to delete?');" runat="server"></asp:LinkButton>
                        </td>
                    </tr>
                  
                </ItemTemplate>
                <FooterTemplate>
                    <tr>
                        <td>
                            <asp:TextBox ID="ftxtEmploymentId" Visible="false"  runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="ftxtFirstName" Visible="false" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="ftxtFirstName" ID="fRequiredFieldValidator1" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                             </td>
                        <td>
                            <asp:TextBox ID="ftxtLastName" Visible="false" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ControlToValidate="ftxtLastName" ID="fRequiredFieldValidator2" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="ftxtSalary" Visible="false"  runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ControlToValidate="ftxtSalary" ID="fRequiredFieldValidator3" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="ftxtAddress" Visible="false"  runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ControlToValidate="ftxtAddress" ID="RequiredFieldValidator4" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="ftxtPhoneNo" Visible="false" runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ControlToValidate="ftxtPhoneNo" ID="fRequiredFieldValidator5" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:LinkButton CausesValidation="false" CommandName="Add"  ID="fbtnAdd" Text="+"  runat="server"></asp:LinkButton>
                            <asp:LinkButton CausesValidation="true" Visible="false" CommandName="Save"   ID="fbtnSave" Text="Save"  runat="server"></asp:LinkButton>
                           
                        </td>
                    </tr>
                    </table>
                </FooterTemplate>
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
