(Windows PowerShell command in /bin/ILMerge folder)
YOU HAVE TO PUT ILMerge.exe and System.Compiler into Release folder (e.g. D:\Example\Example\bin\x64\Release)
LAUNCH ".\ILMerge.exe .\ComplexSystemInfo.exe .\MetroFramework.Design.dll .\MetroFramework.dll .\MetroFramework.Fonts.dll /out:new.exe"
1) ILMERGE
2) APP YOU NEED NEW
3) all dlls
4) /out:new.exe IS THE OUTPUT