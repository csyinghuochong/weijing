::先备份数据库     要合併的区_新区     在修改物理区
cd bin
dotnet Server.dll --AppType=MergeZone --Console=1 --StartConfig=StartConfig/Localhost --Parameters=15_14 --Process 1
pause