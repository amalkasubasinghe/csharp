SET SITENAME=CSTLIB
SET CURPATH=%CD%

call Uninstall.bat

echo %SITENAME%

%systemroot%\System32\inetsrv\appcmd.exe ADD SITE /name:%SITENAME% /bindings:http://*:8001,net.tcp/9001:* /physicalPath:%CURPATH%\%SITENAME%
%systemroot%\System32\inetsrv\appcmd.exe SET APP /app.name:%SITENAME%/ /enabledProtocols:"http,net.tcp"
%systemroot%\System32\inetsrv\appcmd.exe SET CONFIG %SITENAME% /section:anonymousAuthentication /enabled:true /commit:apphost
