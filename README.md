# GoogleDriveAuthCSharpASPNETWebApp

Clone the project.

Clean and rebuild the project.

Rebuilding process will install all the dependancies and nuget packages which are needed to run the project.

Development Testing
-------------

Run the project in visual studio after rebuilding.


Deployment
-------------

1) Rebuild the project.
2) Open the GoogleAuthWebApp solution in Visual Studio. In the Solution Explorer, 
expand the GoogleAuthWebApp.Web\References folder. Select assemblies whose names start with "DevExpress". 
If you use Entity Framework, third-party controls or modules, select their assemblies as well. 
In the Properties window, set the CopyLocal property to True.
3) Change the Active Solution Configuration from Debug to Release.
4) Open the MySolution.Web\Web.config file. In the system.web section, set the compilation's debug option to false.
5) Build and run the ASP.NET application.
6) Check that the application performs correctly and close it.
7) Ensure that the GoogleDriveAuthCSharpASPNETWebApp\GoogleAuthWebApp.Web folder contains application files.
8) If the MySolution\MySolution.Web\Bin folder contains PDB files, remove them.
9) Perform this step on the Developer Workstation. Right-click the GoogleAuthWebApp.Web project in Solution Explorer.
Choose Publish... Specify the target location in the invoked Publish Web dialog and click Publish.

For more information, please visit the below URL.

https://documentation.devexpress.com/eXpressAppFramework/113246/Deployment/Deployment-Tutorial/Publish-Web-Deployment-of-an-ASP-NET-Application
