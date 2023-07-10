::先备份数据库     要移除的区->目标区     在修改物理区
cd bin
dotnet Server.dll --AppType=MergeZone --Console=1 --StartConfig=StartConfig/Localhost --Title=MergeZone --Parameters=9_5 --Process 1
pause