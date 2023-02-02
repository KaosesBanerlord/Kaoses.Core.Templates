# Bannerlord Module Template
## Overview
Base on the template by the BUTR team from [GitHub](https://github.com/BUTR/Bannerlord.Module.Template) it has been customised for ease of use with Kaoses mods.

## Installation
1. Install the latest [.NET Core SDK](https://dot.net).
2. Run `dotnet new install {FullPath}\bannerlord.Templates.CoreModule.1.0.4.nupkg` to install the project templates.
or 

Alternativly can download and install the .nuget package `dotnet new install bannerlord.Templates.CoreModule.x.x.x.nupkg`

## Updating
1. Run `dotnet new install {FullPath}\bannerlord.Templates.CoreModule.1.0.4.nupkg` to update the project templates.

## Uninstalling
run `dotnet new uninstall bannerlord.Templates.CoreModule`
alternativly run `dotnet new uninstall` to list all uninstall commands

## Packaging
changee NugetsOutput to a folder in Bannerlord.Templates.Kaoses.csproj then in a terminal at the src folder run `dotnet pack`. The nuget file will be copied to the output folder 

## Creating a new Module

### Creating from command line:
1. Choose a project template i.e. `blkct`.
2. Run `dotnet new bltk --help` to see how to select the feature of the project.
3. Run `dotnet new bltk --name "Bannerlord.MyModule"` along with any other custom options to create a project from the template.

### Creating via Visual Studio
You need to have at least an 16.8.x version to create the template!  
You also need to use the new template feature:  
<p>
   <img src="https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2020/09/clitemplates-option-enable.png" width="600">
</p>
Alternativly
Open Visual Studio Installer. Locate the Visual Studio 2022 panel and click "Modify". On the right, in the "Installation details" menu, under "ASP.NET and web development" and then "Optional", check "Additional project templats (previous versions)". Click "Modify" and you'll be done!

## FAQ
### What 'Target Framework' should I chose?
If you plan on using Harmony or WinForms, use `.NET Framework 4.7.2`. If not, you can chose `.NET Standard 2.0`.  
### What are the differences between 'soft-dependency' and 'hard-dependency?
**Hard dependency** means that an entry will be added to `SubModules.xml`. Your Module will not include the dependency inside it's `/bin` folder (the .dll). 
It won't allow the game to run your mod without the dependency installed as a separate Module. This is an important feature to prevent having multiple versions 
of the same dependency running within the game.  
**Soft dependency** means that nothing will be added to `SubModules.xml`. Your Module will include the dependency inside it's `/bin` folder (the .dll).
### What is this variable 'Bannerlord Game Folder Location'?
`$(BANNERLORD_GAME_DIR)` is an environment variable. We think that it would be best to set it once on the system instead of hardcoding the game path in the project.  
Feel free to replace it with a full folder path like `C:\Program Files (x86)\Steam\steamapps\common\Mount & Blade II Bannerlord` if you don't want to use the environment variable.  
### What is this variable 'Module Name'?
`$(MSBuildProjectName)` is a MSBuild built-in variable that returns the file name of the project file without the file name extension; for example, `Bannerlord.Module1`.  
If you don't plan on keeping the Module folder name the same as the project that is being created, override it.  
### What is this variable 'Language Version'?
The version of C# that is used. By default, the value is `9.0`, which is the latest currently.  
### Should I set 'Use Nullable Feature'?
Read the [docs](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references) on Nullable reference types to decide if you need this feature!  
### What are those '$SOMETHING$' variables inside SubModules.xml?
Those are variables that will be replaced with real values when the project is built.  
* **$modulename$** is the varible you passed in `Module Name` when creating the Module. It is the `<ModuleName>` property used in your project file (`.csproj`)
* **$version$** is the `<Version>` property used in your project file (`.csproj`)
### What is the '\_Module' folder inside the project?
It is the root Module folder that copies everything that is placed there inside the output.
### I build my project and a folder with my Module was created in `GAMEPATH/Modules`!
This is one of the features that this project template provides.  
If the `<ModuleName>` and `<GameFolder>` properties are valid, your Module will be copied in the game's `/Modules` folder automatically. You can test your Module without the need of 
creating a script that will move everything inside the game's Modules folder.
