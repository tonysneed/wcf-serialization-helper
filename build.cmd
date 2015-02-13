@echo On
set debug=%1

REM Set Variables:
set config="%Configuration%"
if %config% == "" (
   set config=Release
)
set version="%PackageVersion%"

REM Build:
if "%debug%"=="1" pause
mkdir "releases\%PackageVersion%\WcfSerializationHelper\net45"
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild "src\WcfSerializationHelper\WcfSerializationHelper.csproj" /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=releases\%PackageVersion%\WcfSerializationHelper\msbuild.log /verbosity:normal /nr:false
if "%debug%"=="1" pause
if not "%errorlevel%"=="0" exit

REM Package:
if "%debug%"=="1" pause
.nuget\nuget.exe pack "src\WcfSerializationHelper\WcfSerializationHelper.csproj" -symbols -o "releases\%PackageVersion%\WcfSerializationHelper\net45" -p Configuration=%config%;PackageVersion=%version%
if "%debug%"=="1" pause
if not "%errorlevel%"=="0" exit
