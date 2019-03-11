# Install Visual Studio

* Open Marketplace
* Enter Visual Studio and select result (opening in a browser)
* Download Community Edition
* Select .NET Development when asked which components to Install
* On first start select Visual C# as Development Settings
* After Visual Studio started install the following extension
  Tools -> Extensions and Updates... -> Online -> Microsoft Visual Studio Installer Projects
* Restart Visual Studio to complete installation

# Building the project
In Visual Studio
* Click Teams -> Manage Connections
* Under "Local Git Repositories" in side bar select clone and enter URL of repo
* In the top toolbar select "Release" in the Solution Configurations drop-down menul
* In the Solution Explorer Sidebar right-click on Setup and select Build
* If building was successful two files setup.exe and Setup.msi will be located inside the source folder's Setup\Release directory
* Done
