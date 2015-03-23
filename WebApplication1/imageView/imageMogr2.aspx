<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imageMogr2.aspx.cs" Inherits="WebApplication1.imageView.imageMogr2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="高级图片处理原图"></asp:Label><asp:TextBox ID="TextBox1" runat="server">http://liuhanlin-work.qiniudn.com/liuhanlin.jpg</asp:TextBox><asp:Button ID="Button1" runat="server" Text="展示" OnClick="Button1_Click" /><asp:Image ID="Image1" runat="server" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="去除图片元信息"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="展示" />
        <asp:Image ID="Image2" runat="server" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="基于原图大小，按指定百分比缩放。"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="展示" />
        <asp:Image ID="Image3" runat="server" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="以百分比形式指定目标图片宽度，高度不变。"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
        <asp:Image ID="Image4" runat="server" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="	指定目标图片宽度，高度等比缩放"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
        <asp:Image ID="Image5" runat="server" />
        <br />
        <asp:Label ID="Label6" runat="server" Text="	限定长边，短边自适应缩放，将目标图片限制在指定宽高矩形内。"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Button" />
        <asp:Image ID="Image6" runat="server" />
        <br />
        <asp:Label ID="Label7" runat="server" Text="限定目标图片宽高值，忽略原图宽高比例，按照指定宽高值强行缩略，可能导致目标图片变形"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Button" />
        <asp:Image ID="Image7" runat="server" />
        <br />
        <asp:Label ID="Label8" runat="server" Text="gif图片处理"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server">http://liuhanlin-work.qiniudn.com/liuhanlin.gif</asp:TextBox>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Button" />
        <asp:Image ID="Image8" runat="server" />
        <br />
        <asp:Label ID="Label9" runat="server" Text="缩放后裁剪"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Button" />
        <asp:Image ID="Image9" runat="server" />
        <br />
        <asp:Label ID="Label10" runat="server" Text="裁剪后缩放"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Button" />
        <asp:Image ID="Image10" runat="server" />
        <br />
        <asp:Label ID="Label11" runat="server" Text="图片旋转"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Button" />
        <asp:Image ID="Image11" runat="server" />
    </div>
    </form>
</body>
</html>
