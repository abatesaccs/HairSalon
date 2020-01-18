# HairSalon
##### By Andrew Bates
###### Last Updated Jan 17 2020

## Description

This is a HairSalon management program designed to help keep track of stylists and customers.

## Specifications:

The user will be able to:

  - store a list of stylists 
  - store a list of customers per stylist
  - edit, delete, and add stylists
  - edit, delete, and add customers

## Links:

Github - https://github.com/HairSalon

## Setup/Installation Requirements:

1. Open https://github.com/HairSalon
2. Clone repository to local machine 
3. Install .NET and ASP.NET Core
4. Downliad and install SQL Server
5. In the terminal:

  - $ dotnet build - when you are ready to build project
  - $ dotnet run - to run the project 
  - $ dotnet test - for testing the project

## To create the tables: 

CREATE TABLE `customers` (
  `CustomerId` int NOT NULL AUTO_INCREMENT,
  `Description` varchar(255) DEFAULT NULL,
  `StylistId` int DEFAULT '0',
  PRIMARY KEY (`CustomerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

## Known Bugs

* _No known bugs at this time_

## Technologies Used:

* C#
* .NET
* ASP.NET Core
* Entity
* linq

## License
MIT License

Copyright (c) 2020 Andrew Bates