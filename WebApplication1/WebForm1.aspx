<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 250px;
        }
    </style>
</head>
<body style="height: 463px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="208px" Width="301px">
        </asp:GridView>
        <p>
            <asp:Button ID="Win" runat="server" Height="47px" OnClick="Win_Click" Text="Win" Width="264px" />
        </p>
        <asp:Button ID="Japan" runat="server" OnClick="Japan_Click" Text="Japan Data" Width="260px" />
        <p>
            <asp:Button ID="Draw" runat="server" Height="37px" OnClick="Draw_click" style="margin-top: 0px" Text="Draw" Width="261px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
