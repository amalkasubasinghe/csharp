SET _SITENAME="CSTLIB"

%systemroot%\System32\inetsrv\appcmd.exe DELETE APP %_SITENAME%/
%systemroot%\System32\inetsrv\appcmd.exe DELETE SITE %_SITENAME%