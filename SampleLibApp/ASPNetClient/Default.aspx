<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPNetClient._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <h1>Charmain's Liberary</h1>
    <a href="">Add New Book</a>
    
    <table border="1">
        <tr>
            <th>ISBN</th>
            <th>Name</th>            
            <th>Author</th>  
            <th>Description</th>  
            <th>Borrowed by</th>
            <th>Borrowed Date</th>            
            <th>Action</th>
        </tr>
        <tr> 
                   
            <td>1</td>
            <td>Wicket In Action</td>
            <td>Amalka Subasinghe</td>
            <td>2010-04-08</td>            
            <td><a href="">Return</a></td>
        </tr> 
        <tr>            
            <td>2</td>
            <td>Struts In Action</td>            
            <td></td>
            <td></td>            
            <td><a href="">Issue</a></td>
        </tr> 
    </table>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
