<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Download.aspx.cs" Inherits="WebApplication1.Download" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="原始url"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;<asp:Label ID="Label2" runat="server" Text="私有空间下载url"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="生成" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
