# _Eau Claire's Salon_

#### _C# ASP.NET Core MVC and EF Core practice for Epicodus, 07.31.2020_

#### By _**Brittany Lindgren**_


## Description

_Welcome Claire! Now keeping your business organized is easier than ever! You can use this personalized application to help you keep track of your stylists and their clients. 

## Specifications

| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|
|  Program will add a stylist's name and a list of all their clients to the database to create a list of stylists  |  Name: Robert, Clients: client1, client2  |  StylistColumn: Robert StylistId: 1  |  N  |
|  Program will get stylist's details and clients from database when you click on their name | Select Robert | Name: Robert, Clients: client1, client2 |  N  |   
|  Program will add a client and their details to the database and associate them with a stylist based on the stylist's Id | Jules, prefers Monday appointments, Robert's client |  Jules - StylistId 1 (Robert)  |  N  | 
|  Program will get client's details from the database if you click on their name  | Client: Jules, Prefered appointment days: Monday, Prefered Stylist: Robert |  N  |




## Stretch Goals
| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|
| Program will update a client or a stylist's information in the database | Edit "Name" | Selected person's information updated in the database | N |
| Program will delete a client or a stylist from the database | delete "Name" | Selected person removed from database | N |


## Setup/Installation Requirements

  1. Follow this [link to the project repository](PUT LINK HERE) on GitHub.  
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose **open with...** and open using a text editor such as VS Code or Atom, etc.
  8. Once you are inside of your text editor, open the terminal. If you are in VS Code for example, this can be done by clicking on `Terminal` at the top of the editor and then selecting `New Terminal`. **You can navigate to different directories in the project by typing `cd DirectoryName` to go down into specific directories or `cd ..` to go back up one directory. 
  9. Navigate to the Salon directory by typing `cd Restaurant` in your terminal and hitting `enter`. Then type the command `dotnet restore`,`dotnet build`, then `dotnet run` into your terminal and hit enter. You should see files appear inside of your bin folder. The bin folder should appear greyed out. 
  10. Click on the link provided after you see `now listening on: ... ` appear in your terminal.


#### Additional Setup/Installation Notes:

* You will need to configure the MySQL Workbench database in order to run this project. See directions directly below.   
* Do not alter the bin/ or obj/ directories or any of the files in them.

#### Configure the MySQL Workbench Database:
* Install MySQL and MySQL Workbench first. During installation of MySQL you will be asked to create a password. This is important! Take note of your password. Once you have installed MySQL and MySQL Workbenck, start MySQL by entering `mysql -uroot -p+_yourpassword_` in the terminal. Example: password is `tomato`, enter `mysql -uroot ptomato`. If this doesn't work in your terminal, try using your computer's command line interface application. If you are successful, you will see a message in the terminal, ending with the line `mysql>`. Once you have succesfully completed these steps, follow the instructions below.
1. Open MySQL Workbench and double click on the grey box under the line `MySQL Connections` (this box should say `mamp` and have some text and numbers ending in `:3306`). This will launch the MySQL Workbench. You may be prompted to enter the same password that you used in the previous step (ex: `tomato`). 
2. You should see an icon in the upper left that looks like a little piece of paper with the letters `SQL` and a + sign. Hover over the icon and confirm that this is the 'create a new SQL tab for executing queries' icon. Once confirmed, double click the icon.
3. Enter the following text into the window for the SQL File tab.

```CREATE TABLE `brittany_lindgren`.`stylists` (
  `StylistId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL,
  PRIMARY KEY (`StylistId`));

  CREATE TABLE `brittany_lindgren`.`clients` (
  `ClientId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL,
  `PreferredDays` VARCHAR(255) NULL,
  `ShortNotice` VARCHAR(255) NULL,
  PRIMARY KEY (`ClientId`));
```
4. Click 'execute' (this may appear as a lightening bolt icon).

## Known Bugs

| Bug : Message |  Situation  | Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ | ------- |
| Models\Stylist.cs(16,32): error CS0246: The type or namespace name 'Client' could not be found (are you missing a using directive 
or an assembly reference?) [C:\Users\blindgren\Desktop\EPICODUS\Full Time Bootcamp\CS-and-NETCore\independent-projects\EauSalon.Solution\Salon\EauSalon.csproj] | Run `dotnet build` | Y | Update namespace in Stylist.cs from EauSalon to EauSalon.Models |
| Models\EauSalonContext.cs(12,22): error CS1061: 'DbContextOptionsBuilder' does not contain a definition for 'UseLazyLoadingProxies' and no accessible extension method 'UseLazyLoadingProxies' accepting a first argument of type 'DbContextOptionsBuilder' could be found (are you missing a using directive or an assembly reference?) [C:\Users\blindgren\Desktop\EPICODUS\Full Time Bootcamp\CS-and-NETCore\independent-projects\EauSalon.Solution\Salon\EauSalon.csproj] | Run `dotnet build` | Y | Remove `protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){optionsBuilder.UseLazyLoadingProxies();}` from EauSalonContext.cs |
| NullReferenceException: Object reference not set to an instance of an object | Click on 'See a list of all Stylists' link on Splash Page | Y | Create List in StylistsController for Index() to get list of stylists from database, pass list to Index view |
| C:\Program Files\dotnet\sdk\2.2.203\Sdks\Microsoft.NET.Sdk.Razor\build\netstandard2.0\Sdk.Razor.CurrentVersion.targets(510,5): error MSB3027: Could not copy "obj\Debug\netcoreapp2.2\EauSalon.Views.dll" to "C:\Users\blindgren\Desktop\EPICODUS\Full Time Bootcamp\CS-and-NETCore\independent-projects\EauSalon.Solution\Salon\bin\Debug\netcoreapp2.2\EauSalon.Views.dll". Exceeded retry count of 10. Failed.  | Enter command `dotnet watch run` into terminal | Y | remove obj and bin directories, close VS Code, reopen, navigate into Salon directory, enter `dotnet restore` into terminal and then `dotnet build` |
| Views\Shared\_Layout.cshtml(13,7): warning MVC1000: Use of IHtmlHelper.Partial may result in application deadlocks. Consider using <partial> Tag Helper or IHtmlHelper.PartialAsync. [C:\Users\blindgren\Desktop\EPICODUS\Full Time Bootcamp\CS-and-NETCore\independent-projects\EauSalon.Solution\Salon\EauSalon.csproj] | n/a | Y | X |
| Models\Stylist.cs(17,12): error CS0246: The type or namespace name 'DateTime' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\blindgren\Desktop\EPICODUS\Full Time Bootcamp\CS-and-NETCore\independent-projects\EauSalon.Solution\HairSalon\EauSalon.csproj] | `dotnet build` | Y | Add `using System;` statement to top of Stylist.cs file |
| Text in 'Hire Date' form field is white | Views/Stylists/Create.cshtml | N | x |
| MySqlException: Unknown column 'WorkDay' in 'field list' | Submit Create Stylist form | N | x |
| x | x | N | x |



## Support and contact details

_Please feel free to contact the authors through GitHub (LINDGRENBA) with any feedback, questions or concerns._


## Technologies Used

* C#
* .NET-Core 2.2
* ASP.NET Core MVC
* Visual Studio Code
* Git Version Control
* GitHub


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_{Brittany Lindgren}_**