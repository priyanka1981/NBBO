<%@ Page Language="C#" Inherits="NBBO_UI.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
         <asp:Button id="button1" runat="server" Text="Start" OnClick="button1Clicked" /><br><br>
            
         <asp:Label runat="server" Style="display=none" Visible="false" id="lbltext">Please enter ticker to see NBBO:</asp:Label><br><br>
            <asp:TextBox id="txtTicker" runat="server" Visible="false" ></asp:TextBox><br><br>
            <asp:Label runat="server" id="lblError" Visible="false" Style="font:bold;color:red;"></asp:Label><br>
            <asp:Button id="buttonFetch" runat="server" Text="Fetch NBBO" Style="display=none" OnClick="buttonFetchClicked" Visible="false" /><br><br>
		
           <asp:DataGrid id="dgDataGrid" runat="server"></asp:DataGrid><br><br><br>
           <asp:DataGrid id="dgNBBOGrid" runat="server"></asp:DataGrid><br><br>
            
	</form>
</body>
</html>
