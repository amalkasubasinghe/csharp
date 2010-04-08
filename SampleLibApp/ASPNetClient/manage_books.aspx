<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_books.aspx.cs" Inherits="ASPNetClient.manage_books" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <h1>Manage Books</h1>
    <a href="">Add New Book</a> 
    
    <table border="1">
        <tr>
            <th>Book Id</th>
            <th>Name</th>
            <th>Author</th>
            <th>Description</th>            
            <th>Action</th>
        </tr>
        <tr>            
            <td>1</td>
            <td>Wicket In Action</td>
            <td>Author goes here...</td>
            <td>Description goes here ...</td>            
            <td><a href="">Edit</a> | <a href="">Delete</a></td>
        </tr> 
        <tr>            
            <td>2</td>
            <td>Struts In Action</td>
            <td>Author goes here...</td>
            <td>Description goes here ...</td>            
            <td><a href="">Edit</a> | <a href="">Delete</a></td>
        </tr> 
    </table>
    
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
