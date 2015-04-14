https://visualstudiogallery.msdn.microsoft.com/daf5c6db-386b-4994-bdd7-b6cd52f11b72

HOW TO USE:

Add a new project to your solution by using the installed template
Open NuGet.config and add your repositories to the "packageSources" element.
The script will then publish your package to all the listed repositories.
Edit the sample "Package.nuspec" file according to http://docs.nuget.org/docs/reference/nuspec-reference
Add the assemblies you want to add as references in the "lib" folder before building the project
See http://docs.nuget.org/docs/creating-packages/creating-and-publishing-a-package#Package_Conventions
Add the files you want to copy to the project folder in the "content" folder before building the project
Remember that you can also do config and file transforms. http://docs.nuget.org/docs/creating-packages/configuration-file-and-source-code-transformations
Edit one or more of the files in the "tools" folder if you want to run some script on package install, uninstall or init.
See http://docs.nuget.org/docs/creating-packages/creating-and-publishing-a-package#Automatically_Running_PowerShell_Scripts_During_Package_Installation_and_Removal
Build the project.
If in release mode, the packager will try to push your package to the repository using the NuGet API Keys configuration. 
If no valid API key for the specified package source exists, it will prompt you to add it before automatically trying again. 
If in debug mode, it will only create the packages.