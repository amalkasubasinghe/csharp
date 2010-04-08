<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_employees.aspx.cs" Inherits="ASPNetClient.manage_employees" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <h1>Manage Employees</h1>
    
    <a href="">Add New Employee</a> 
    
    <table border="1">
        <tr>
            <th>Employee Id</th>
            <th>Name</th>            
            <th>Action</th>
        </tr>
        <tr>            
            <td>1</td>
            <td>Amalka Subasinghe</td>            
            <td><a href="">Edit</a> | <a href="">Delete</a></td>
        </tr> 
        <tr>            
            <td>2</td>
            <td>Rasika Weliwita</td>
            <td><a href="">Edit</a> | <a href="">Delete</a></td>
        </tr> 
    </table>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
