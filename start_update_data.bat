::先备份数据库     要移除的区->目标区     在修改物理区
cd binET
dotnet Server.dll --AppType=UpdateDB --Console=1 --StartConfig=StartConfig/Localhost --Title=MergeZone --Process 1
pause