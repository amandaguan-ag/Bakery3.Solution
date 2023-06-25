# _Pierre's Sweet and Savory Treats_

#### By _**Amanda Guan**_

#### _A website to track Pierre's sweet and savory treats_

## Technologies Used

- _C#_
- _.Net 6.0_
- _ASP .Net Core MVC_
- _Razor View Engine_
- _Identity_
- _Entity Core Framework_
- _Markdown, CSS, Bootstrap, HTML_

## Description

_This is a MVC website created to allow a business owner to market their sweet and savory treats. All users have read access to content on the website, but only users logged in can create, update, or delete items. The application provides a many-to-many relationship between different treats and flavors._

_The website implements user authentication. A visitor can create an account, then log in and log out. Once logged in, users gain access to create, update, and delete functionalities._

_All visitors, even without logging in, can view the list of treats and flavors. However, in order to contribute by adding, updating, or deleting items, users must be logged in._

## Setup/Installation Requirements

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory.
3. Within the production directory "Bakery", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

5. Within the production directory "HairSalon", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
6. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

- _At the moment: user can enter 'blank' or repeat Flavors/Treats as well as the wrong data type, such as letters for a numbers._

## License

MIT License

Copyright (c) _June_2023_ _Amanda Guan_
