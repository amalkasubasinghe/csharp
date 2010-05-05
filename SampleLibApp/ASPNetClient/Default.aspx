<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="com.library.ASPNetClient._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Library</title>
</head>
<body>

    <h1>Library</h1>
    
    <table border="1" width="100%">
    <tr>
    <td valign="top">
        <table border="1" width="100%">
        <tr>
            <th>ISBN</th>
            <th>Name</th>            
            <th>Author</th>  
            <th>Description</th>  
            <th>Borrowed by</th>
            <th>Borrowed Date</th>                        
        </tr>   
            
        <%
            foreach (String row in rows)
            {
                Response.Write(row);
            }
        %> 
        </table>   
    </td>
    <td>
        <form runat="server" id="form1">
        <table>
            <tr><th>Add/Update/Delete Book</th></tr>
            <tr><td><asp:label id="lblBookMessage" runat="server" font-bold="True" font-italic="True" font-size="Medium" forecolor="#C00000"></asp:label></td></tr>
            <tr><td>
                
                <table border="1">
                    <tr>
                        <th>ISBN</th>
                        <td>: <asp:textbox id="txtIsbn" runat="server" width="200px"></asp:textbox></td>        
                    </tr>
                    <tr>
                        <th>Name</th>
                        <td>: <asp:textbox id="txtName" runat="server" width="200px"></asp:textbox></td>        
                    </tr>
                    <tr>
                        <th>Author</th>
                        <td>: <asp:textbox id="txtAuthor" runat="server" width="200px"></asp:textbox></td>        
                    </tr>
                    <tr>
                        <th>Description</th>
                        <td>: <asp:textbox id="txtDescription" runat="server" width="200px"></asp:textbox></td>        
                    </tr>
                    <tr>
                        <th></th>
                        <td><asp:button id="cmdAdd" runat="server" text="Add"> </asp:button>
                            <asp:button id="cmdUpdate" runat="server" text="Update" 
                                onclick="cmdUpdate_Click" > </asp:button>
                            <asp:button id="cmdDelete" runat="server" text="Delete" 
                                onclick="cmdDelete_Click" > </asp:button></td>        
                    </tr>
                </table>                  
            </td></tr>
            <tr><th>Issue/Return Book</th></tr>
            <tr><td><asp:label id="lblIssueMessage" runat="server" font-bold="True" font-italic="True" font-size="Medium" forecolor="#C00000"></asp:label></td></tr>
            <tr><td>                
                <table border="1">
                    <tr>
                        <th>ISBN</th>
                        <td>: <asp:textbox id="txtIssueIsbn" runat="server" width="200px"></asp:textbox></td>        
                    </tr>
                    <tr>
                        <th>Employee Name</th>
                        <td>: <asp:textbox id="txtEmpName" runat="server" width="200px"></asp:textbox></td>        
                    </tr>                    
                    <tr>
                        <th></th>
                        <td><asp:button id="cmdIssue" runat="server" text="Issue" onclick="cmdIssue_Click" ></asp:button>
                            <asp:button id="cmdReturn" runat="server" text="Return" 
                                onclick="cmdReturn_Click" ></asp:button></td>        
                    </tr>
                </table>                
            </td></tr>
        </table>   
        </form>    
    </td>
    </tr>
    </table>
    
   
    
</body>
</html>
