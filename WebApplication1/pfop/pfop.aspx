<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pfop.aspx.cs" Inherits="WebApplication1.pfop.pfop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="查询处理状态"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="查询" />
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="音频转码" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox1" runat="server" Width="256px"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="jpg转svg" />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
    </div>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="视频缩放" />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="webm" />
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="视频水印并截取" />
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="音频打图片水印" />
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="音频转码" />
        <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="视频截图" />
        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="截取7.1秒的视频图片" />
        <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="视频切片hls" />
        <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="视频音轨处理" />
        <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
    </form>
</body>
</html>
