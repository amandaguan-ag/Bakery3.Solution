# _Dr. Sillystringz's Factory_

#### By _**Amanda Guan**_

#### _A C# web application to manage Machines and Engineers for 'Dr. Sillystringz's Factory' using an SQL database and many-to-many relationships._

## Technologies Used

* _C#_
* _.Net 6.0_
* _ASP .Net Core MVC_
* _Razor View Engine_
* _MySQL Workbench_
* _Entity Core Framework_
* _Markdown, CSS, Bootstrap, HTML_

## Description

_This project consists of an C# MVC web application that allows 'Mr.Sillystring' to manage information on his factory's Engineers and Machines. It allows the management of the fictional 'Factory' to add Engineers and Machines to an SQL Database with the use of Entity Core Framework. The manager can also view details for each Engineer/Machine and delete relationships and objects. The project was created as a code review for Epicodus following the Many-To-Many-Relationships section of C#._


## Setup/Installation Requirements

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "HairSalon".
3. Within the production directory "HairSalon", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. 

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

5. Within the production directory "HairSalon", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

* _At the moment: user can enter 'blank' or repeat Engineers/Machines as well as the wrong data type, such as letters for a numbers._

## License

MIT License

Copyright (c) _June_2023_ _Amanda Guan_