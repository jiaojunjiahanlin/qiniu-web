<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imageView2.aspx.cs" Inherits="WebApplication1.imageView.imageView2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="图片链接"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="打水印的文字"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="图片水印链接" OnClick="Button1_Click" />
        <asp:Label ID="Label3" runat="server" Text="看我的"></asp:Label>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="原图" />
        <asp:Image ID="Image2" runat="server" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="模式0--300*200"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server">http://liuhanlin-work.qiniudn.com/liuhanlin.jpg</asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="展示" />
        <asp:Image ID="Image1" runat="server" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="模式1--200*200"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server">http://liuhanlin-work.qiniudn.com/liuhanlin.jpg</asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="展示" />
        <asp:Image ID="Image3" runat="server" />
        <br />
        <asp:Label ID="Label6" runat="server" Text="模式2"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" Text="Button" />
        <asp:Image ID="Image4" runat="server" />
        <br />
        <asp:Label ID="Label7" runat="server" Text="模式3"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" Text="Button" />
        <asp:Image ID="Image5" runat="server" />
        <br />
        <asp:Label ID="Label8" runat="server" Text="模式4"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:Button ID="Button7" runat="server" Text="Button" />
        <asp:Image ID="Image6" runat="server" />
        <br />
        <asp:Label ID="Label9" runat="server" Text="图片水印"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:Label ID="Label10" runat="server" Text="水印图片"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="打图片水印" />
        <asp:Image ID="Image7" runat="server" />
    </div>
    </form>
</body>
</html>
