SET SITENAME=CSTLIBClient
SET CURPATH=%CD%

call Uninstall.bat

echo %SITENAME%

%systemroot%\System32\inetsrv\appcmd.exe ADD SITE /name:%SITENAME% /bindings:http://*:8080 /physicalPath:%CURPATH%\%SITENAME%
%systemroot%\System32\inetsrv\appcmd.exe SET APP /app.name:%SITENAME%/ /enabledProtocols:"http"
%systemroot%\System32\inetsrv\appcmd.exe SET CONFIG %SITENAME% /section:anonymousAuthentication /enabled:true /commit:apphost
