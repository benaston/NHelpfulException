@echo off
cd /d %0\.. 

:: Accept command line parameter for non-interactive mode
if "%1" == "" goto loop
set task= "%1"
set interactive= "false"
goto switch

:loop
set interactive= "true"
set /p task= usage: (b)uild(d)ebug / (b)uild(s)taging / (b)uild(r)elease  / (c)lean / (f)ast (t)ests / (s)low (t)ests?:
:: Weird string normalisation or something..
set task= "%task%"

:switch
if %task% == "bd" goto builddebug
if %task% == "br" goto buildrelease
if %task% == "bs" goto buildstaging
if %task% == "c" goto clean
if %task% == "ft" goto fasttests
if %task% == "st" goto slowtests

:resume
echo.
echo Completed at %date% %time%
echo.
if %interactive% == "true" goto loop
goto done

:builddebug
C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe /m:8 /verbosity:q /p:Configuration=Debug "%CD%\..\src\nhelpfulexceptions.sln"
goto resume

:buildrelease
C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe /m:8 /p:Configuration=Release "%CD%\..\src\nhelpfulexceptions.sln"
goto resume

:buildstaging
C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe /m:8 /p:Configuration=Staging "%CD%\..\src\nhelpfulexceptions.sln"
goto resume

:clean
cd %CD%\..\src\
call %CD%\..\src\clean.bat
goto resume

:fasttests
call %CD%\run-tests.bat "f"
goto resume

:slowtests
call %CD%\run-tests.bat "s"
goto resume

:done
