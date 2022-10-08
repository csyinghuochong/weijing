::先备份数据库     要合併的区_新区
cd bin
dotnet Server.dll --AppType=MergeZone --Console=1 --Parameters=2_3 --Process 1
pause