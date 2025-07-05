::先备份数据库     要移除的区—>新区     在修改物理区
cd publish
dotnet Server.dll --AppType=MergeZone --Console=1 --StartConfig=StartConfig/Beta --Title=MergeZone --Parameters=154_153 --Process 1
pause