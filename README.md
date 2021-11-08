# Sports Store MVC Demo

#### Projects
-LogginLibrary(for logging)
-SportsStoreDomainLibrary(DAL)
-SportsStoreMVCWebApp
SportsStoreMVCWebAPI


#### Dependency Injection
-Unity(Microsoft,Will use this in current project)
-Autofac
-Ninject
-StructureMap

#### Packages for the Project
-Install-Package Unity
-Install-Package Fontawesome
-Install-Package EntityFramework(for SportsStoreMVCWebApp)

#### EntityFramework (Code First)
-Commands
   -EntityFramework\Enable-Migrations: will create the Configuration.cs class with mapping  
    to the 'DbContext Class' and provide a 'Seed' Method
      -EntityFramework\Enable-Migrations -ContextTypeName 
       SportsStoreDomainLibrary.SportsStoreDbContext 
       - MigrationsDirectory DataContexts\SportsStoreMigrations -ContextProjectName SportsStoreDomainLibrary
   -EntityFramework\Add-Migration: Will create the class with the structure
    and constraints for the EntityClass for the Database
       -EntityFramework\Add-Migration -ConfigurationTypeName
       SportsStoreMVCWenApp.DataContexts.SportsStoreMigrations.Configuration 
       "InitialCreate"
    -EntityFramework\Update-database: will create the database
     if does not exists else update it ,it will add records
    from the seed method if they do not exists
    -EntityFramework\Update-Database -ConfigurationTypeName SportsStoreMVCWenApp.DataContexts.
    SportsStoreMigrations.Configuration -verbose
   
 

### Git Branches
-01Logging
-02DAL
-03MVCStart
-04ProductController
-05EFDatabase
-06Pagination
-07ViewModels
-08PagingUI
-09NavCategory
-10Cart
-11Admin