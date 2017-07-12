# Reloading `appsettings.json` at each change in .NET core 1.1 console app

This example attempts to reproduce the method described in [this great article](https://andrewlock.net/reloading-strongly-typed-options-in-asp-net-core-1-1-0/)
by Andrew Lock in order to have `appsettings.json` reloaded and bound to a strongly typed object every time the file changes.

The orginal article is for an ASP.NET core 1.1.0 app, while the example here uses a .NET core 1.1 console application with no ASP.

## Compiling and running the application

The files supplied can be imported in Visual Studio (version 2017 used to produce this example). The files can also be compiled and deployed at the command line as follows:

  1. Open a command prompt and make sure the `dotnet` command is available (without arguments, returns info about the command).
  2. Run `dotnet restore` to recover nuget packages required by the example.
  3. Run `dotnet build` to build the example.
  4. Run `dotnet run` to run the example

The application simply writes the values of two parameters from `appsettings.json` to the console. The user is asked to either press a key to repeat, or hit `enter` to exit.

## Expected behavior (currently not working)

If one of the two values in `appsettings.json` is changed between two iterations of the loop, the values displayed should change.

NOTE: be careful to modify the copy of `appsettings.json` in the folder where the executable lies (`bin\Debug\netcoreapp1.1`).
