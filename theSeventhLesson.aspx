<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="theSeventhLesson.aspx.cs" Inherits="ProjectEchart.theSeventhLesson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        请输入一个年份<asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
    
        <asp:Button ID="btnCheckYear" runat="server" OnClick="btnCheckYear_Click" Text="检测是否为闰年" />
    
    </div>
    </form>
</body>
</html>
