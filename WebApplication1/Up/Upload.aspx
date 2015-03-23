<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="WebApplication1.Up.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title>Upload</title>
</head>
<body >
   <form method="post" action="http://upload.qiniu.com/" enctype="multipart/form-data">
 
  <input name="x:hello" type="hidden" value="愛してる"/>
  <input name="token" type="text" value=""/>
  <input name="file" type="file" />
  <input name="accept" type="hidden" />
  <input type="submit" name="up" />
</form>
   
</body>
</html>
