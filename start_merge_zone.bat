::先备份数据库     要移除的区->目标区     在修改物理区
cd bin
dotnet Server.dll --AppType=MergeZone --Console=1 --StartConfig=StartConfig/Localhost --Parameters=30_29 --Process 1
pause