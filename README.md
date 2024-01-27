# Bakery Order

A web application to tracker vendors and their respective orders, built with C# and Razor Pages, using the MVC structure.

By Henry Oberholtzer

## Technologies Used

- C#
- MSTest
- Razor Pages

## Description

## User Stories
- User should see a splash page presenting at the root `/` a link to create new vendors or view vendors
- User should be able to create a `Vendor` instance
- User should be able to delete a specific `Vendor` and all its respective `Orders`
- The `Vendor` class should include, at minimum a property for the name, description and a list of `Orders`
- The `Vendor` class should be fully tested
- User should be able to create `Orders` linked to a specific `Vendor`
- User should be able to delete a specific `Order` instance within a `Vendor`
- User should be able to delete all `Order` instances within a vendor, without deleting the vendor
- Orders should contain properties for a title, description, the cost of the order


## Technical requirements
- Splash page is used
- "Vendor" and "Order" classes
- Two or more controllers
- Models are thoroughly tested
- GET and POST requests and responses are used correctly
- MVC routes follow RESTful requirements

## Features not tested
- Vendor.FindOrder(string id)
- Order.VendorId

## Project Structure

```
VendorTracker.Solution/
├─ VendorTracker/
│  ├─ Controllers/
│  │  ├─ HomeController.cs
│  │  ├─ VendorsController.cs
│  │  ├─ OrdersController.cs
│  ├─ Models/
│  │  ├─ Vendor.cs
│  │  ├─ Order.cs
│  ├─ Views/
│  │  ├─ Home/
│  │  │  ├─ Index.cshtml
│  │  ├─ Vendors/
│  │  │  ├─ Index.cshtml
│  │  │  ├─ New.cshtml
│  │  │  ├─ Show.cshtml
│  │  │  ├─ DeleteAll.cshtml
│  │  │  ├─ Delete.cshtml
│  │  ├─ Orders/
│  │  │  ├─ Index.cshtml
│  │  │  ├─ New.cshtml
│  │  │  ├─ Show.cshtml
│  │  │  ├─ DeleteAll.cshtml
│  │  │  ├─ Delete.cshtml
│  │  ├─ Shared/
│  │  │  ├─ _Layout.cshtml
│  │  │  ├─ Header.cshtml
│  ├─ VendorTracker.csproj
│  ├─ Program.cs
├─ VendorTracker.Tests/
│  ├─ ModelTests/
│  │  ├─ VendorTests.cs
│  │  ├─ OrderTests.cs
│  ├─ VendorTracker.Tests.csproj
.gitignore
README.md
```

## Setup/Installation Requirements

- .NET required for set up.
- To establish locally, download the [repository](https://github.com/henry-oberholtzer/vendors-and-orders) to your computer.
- Open the folder with your terminal and run `dotnet restore` to gather necessary resources.
- To run the application, within the solution folder, run the command `dotnet run` after the restore.
- The application will appear in the terminal.

## Known Bugs

- None at this time

## License

(c) 2024 [Henry Oberholtzer](https://www.henryoberholtzer.com/)

Original code licensed under GNU GPLv3, other code bases and libraries as stated.
