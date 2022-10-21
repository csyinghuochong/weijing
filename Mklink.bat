set dir=Unity2

if not exist %dir% ( md %dir%)

mklink/J H:\GitWeiJing\Unity2\Assets H:\GitWeiJing\Unity\Assets

mklink/J H:\GitWeiJing\Unity2\ProjectSettings H:\GitWeiJing\Unity\ProjectSettings

mklink/J H:\GitWeiJing\Unity2\Packages H:\GitWeiJing\Unity\Packages



pause