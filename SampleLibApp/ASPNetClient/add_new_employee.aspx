<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_new_employee.aspx.cs" Inherits="ASPNetClient.add_new_employee" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <h1>Add New Employee</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <th>Name</th>
                <td><input type="text" /></td>        
            </tr>            
            <tr>
                <th></th>
                <td><input type="submit" value="Add"/><input type="submit" value="Cancel"/></td>        
            </tr>
        </table>
    </form>
</body>
</html>
