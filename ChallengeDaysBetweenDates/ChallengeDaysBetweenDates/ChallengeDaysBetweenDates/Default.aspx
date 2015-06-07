<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeDaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        How many days have elapsed?
        <br />
        <br />
        Chose one date:
        <br />
        <asp:Calendar ID="fristCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        Chose a second date:
        <asp:Calendar ID="secondCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" Text="OK" OnClick="okButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
