set dir=Unity3

if not exist %dir% ( md %dir%)

mklink/J D:\weijingHot\trunk_et_weijing\Unity3\Assets D:\weijingHot\trunk_et_weijing\Unity\Assets

mklink/J D:\weijingHot\trunk_et_weijing\Unity3\ProjectSettings D:\weijingHot\trunk_et_weijing\Unity\ProjectSettings

pause