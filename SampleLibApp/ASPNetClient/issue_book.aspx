<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issue_book.aspx.cs" Inherits="ASPNetClient.issue_book" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <h1>Issue Book</h1>
    
    
    <form id="form1" runat="server">
        <table>
            <tr>
                <th>Book</th>
                <td>Struts In Action</td>        
            </tr>
            <tr>
                <th>Employee</th>
                <td>
                    <select>
                        <option>Amalka Subasinghe</option>
                        <option>Rasika Weliwita</option>
                    </select>
                </td>                        
            </tr>
            <tr>
                <th></th>
                <td><input type="submit" value="Issue"/></td>        
            </tr>
        </table>
    </form>
</body>
</html>
