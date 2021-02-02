& "C:/Program Files (x86)/Microsoft Visual Studio/2019/Professional/Common7/Tools/VsDevCmd.bat"
Set-Location -Path C:
git clone https://github.com/ganeshnj/aws-sdk-net.git --depth 1
Set-Location -Path C:\aws-sdk-net
git pull
msbuild .\buildtools\build.proj /p:RunIntegTests=false /p:RunSmokeTests=false