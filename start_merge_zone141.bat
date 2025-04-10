::先备份数据库     要移除的区->目标区     在修改物理区
cd binET
dotnet Server.dll --AppType=MergeZone --Console=1 --StartConfig=StartConfig/Localhost --Title=MergeZone --Parameters=142_141 --Process 1
pause