# Self hosted runner for GitHub Actions
if you already have dotnet : 
- make sure to add dotnet root to your path ( ~/.dotnet or C:\Program Files\dotnet )
- make sure to add dotnet/tools to your path ( ~/.dotnet/tools or C:\Program Files\dotnet\tools )
- make sure to add an env variable named DOTNET_ROOT ( ~/.dotnet or C:\Program Files\dotnet ), this might cause a MSBUILD path not found with roslynator if not set 

if you don't have dotnet, the script should install it for you at ~/.dotnet

## Windows

You need to have in your path :
- powershell (default is C:\Windows\System32\WindowsPowerShell\v1.0)
- unity (default C:\Program Files\Unity\Hub\Editor\...\Editor)
- git (default C:\Program Files (x86)\Git\cmd)

## Analyzers for roslynator

You need to install them yourself using nugget ( and put them below /Packages, which should be the default )
- Microsoft.Unity.Analyzers.1.17.0
- StyleCop.Analyzers.1.1.118
- SecurityCodeScan.VS2019.5.6.7
- Roslynator.Analyzers.4.6.0
- SonarAnalyzer.CSharp.9.12.0.78982

You may want to install the latest version of each



