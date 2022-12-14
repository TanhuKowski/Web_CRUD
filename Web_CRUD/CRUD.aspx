<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="Web_CRUD.CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>        
             <asp:GridView ID="GridShow" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="cancel" OnRowDeleting="Delete" OnRowEditing="Edit" OnRowUpdating="Updated" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
      <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Surname" HeaderText="Surname" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Job" HeaderText="Job" />
                    <asp:BoundField DataField="Position" HeaderText="Position" />
                    <asp:CommandField ShowEditButton="True" ButtonType="Button">
                    <ControlStyle BackColor="darkgreen" ForeColor="White" />
                    </asp:CommandField>
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" >
                    <ControlStyle BackColor="darkred" ForeColor="White" />
                    </asp:CommandField>
                </Columns>
                 <FooterStyle BackColor="White" ForeColor="#000066" />
                 <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                 <RowStyle ForeColor="#000066" />
                 <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F1F1F1" />
                 <SortedAscendingHeaderStyle BackColor="#007DBB" />
                 <SortedDescendingCellStyle BackColor="#CAC9C9" />
                 <SortedDescendingHeaderStyle BackColor="#00547E" />
 </asp:GridView>
        </div>
    </form>
</body>
</html>
