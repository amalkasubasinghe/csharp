=================================================================
Install Instructions
====================
database - execute SQLQuery2.sql to create database csharp-db.dbo and tbl_book table.

WAS server - after building the solution goto \csharp\install directory and excecute Install.bat.
This will install CSTLIB site.

powershell client - goto \csharp\installPowerShellclient directory and excecute installclient.bat
This will register the powershell snapin.
open powershell(x86) shell and add the registered snapin by executing add-snapin.ps1
Now you can excecute following powershell commands
Add-NewBook
Set-Book
Get-AllBooks
Get-Book
Remove-Book
Lend-Book
Return-Book


Kwown Issues and workarounds.
==============================
1. The .net diagnostic logging is implemented in DataAccessWithLinq project. This is using the diagnostic configuration in  WCFServer/web.config file(this is in WCFServer project). logging service will create a log file "log.txt" in your C:\ drive if logging is enabled. You can't delete this file unless you stop the IIS server and kill the w3wp.exe process. 

2. The WCF Clients(powershellclient and ASP.NET client) will not run properly if installed remote to WCFServer.
This is because the server endpoint is hardcoded inside the client.

3. PowerShell client is not allowed to add books with empty strings for name,author and description

4. There are more......




The WCF interface(v.2.0)
=============================
AddBook(Book):boolean
UpdateBook(Book):boolean
DeleteBook(String id):boolean
GetBook(string id):Book
GetAllBooks(string id):List<Book>

borrowBook(string bookId, string name):boolean
returnBook(string bookId):boolean

Table structure(2.0)
===============
book(id, name, author, description, emp_name, borrowed_date, returned_date)






====================================================================================================
Obsolete---Donot read
====================================================================================================

The WCF interface(v.1.0)
==============

AddBook(Book):boolean
UpdateBook(Book):boolean
DeleteBook(String id):boolean
GetBook(int id):Book


AddEmployee(Employee):boolean
UpdateEmployee(Employee):boolean
DeleteEmployee(int id):boolean
GetEmployee(int id):Employee

borrowBook(int bookId, int empId, Date borrowedDate):boolean
returnBook(BorrowingRecord br):boolean
getLastBorrowingRecord(int book_id):BorrowingRecord

Table structure(1.0)
===============
book(id, name, author, description)
employee(id, name)
borrowings(book_id, emp_id, borrowed_date, returned_date)




