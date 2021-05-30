# Billy Walton - Domain Driven Design

billyw@magenic.com

#Clean Architecture in ASP.NET Core
In this repo, I have taken the work that Matthew Renze did in this repo (https://github.com/matthewrenze/clean-architecture-in-asp-net-mvc-5) and I have upgraded it as is from .NET Framework 4.5 to ASP.NET Core 3.1. The code in this repo shows the original authors view of Clean Architecture by implementing the concerns of the MVC application in terms of Domains, as opposed to using the normal folder structure used in MVC applications. He currently has three Domains.

1. Home - For expressing the Home page.
2. Products - For expressing Product Information
3. Contact - For expressing the Contacts page.

Each domain has it's own set of Controllers, Models, and Views folder. There is a Shared folder that contains Views that are shared across the application.

I will be refactoring this code over the course of this class.

The main difference between this version of the code, and the original .NET Framwork code is that instead of needing to configure a custom razor view engine to allow MVC to find the views I simply added some configuration to the startup.cs file.
