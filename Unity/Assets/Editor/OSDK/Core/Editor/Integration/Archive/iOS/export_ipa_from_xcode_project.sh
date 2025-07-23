#!/bin/sh

#构建类型、Debug或Release，外部传入的第一个参数
BuildType=$1

echo "${BuildType}"

#xcode工程路径,外部传入的第二个参数
XcodeProjectPath=$2

echo "${XcodeProjectPath}"

# 切换到当前目xcode项目目录
# shellcheck disable=SC2164
cd "${XcodeProjectPath}"

#工程名字
ProjectName="Unity-iPhone"

# 构建产物路径
ProductsPath=$(dirname "$PWD")/Products

echo ProductsPath="${ProductsPath}"

# Archive路径
ArchivePath=${ProductsPath}/Archive/${ProjectName}".xcarchive"

# 导出ipa所需要的配置文件
ExportOptionsPath=$(dirname "$PWD")/PrepareInfo/${BuildType}/ExportOptions.plist

# Logs路径
LogsPath=$(dirname "$PWD")/Logs

#编译工程
xcodebuild archive \
  -scheme ${ProjectName} \
  -configuration "${BuildType}" \
  -archivePath "${ArchivePath}" \
  -destination 'generic/platform=iOS' || exit 1
  # &> $LogsPath/tmp_build.log \
  

# 从archive中导出ipa
xcodebuild \
  '#从archive中导出ipa' \
  -exportArchive -archivePath "${ArchivePath}" \
  '#构建类型，Debug或Release' \
  -configuration "${BuildType}" \
  '#导出Ipa需要的配置文件exportOptions.plist，此文件很重要' \
  -exportOptionsPlist "${ExportOptionsPath}" \
  '#导出ipa所在的位置' \
  -exportPath "${ProductsPath}" || exit 2
  # &> $LogsPath/tmp_export.log \
  
exit 0
