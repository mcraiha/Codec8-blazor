# Codec8-blazor

Decode [Codec8](https://wiki.teltonika-gps.com/view/Codec#Codec_8) and [Codec8 Extended](https://wiki.teltonika-gps.com/view/Codec#Codec_8_Extended) messages in browser

## Web link

[codec8.raiha.rocks](https://codec8.raiha.rocks/)

## Requirements (end user)

You have to have newish [internet browser](https://docs.microsoft.com/en-us/aspnet/core/blazor/supported-platforms?view=aspnetcore-7.0)

## How to run / develop

### Requirements

You have to have [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) installed,

### Actual run

Run
```
dotnet run
```
  
And then you can open http://localhost:5274 in your browser

## How to publish

### Actual publish

Run
```
dotnet publish -c Release
```
  
and content should be in **bin\Release\net7.0\publish\wwwroot** folder.

## Licenses

All code files (*.cs, *.razor) and HTML files (*.html) are under [PUBLIC DOMAIN](https://opensource.org/licenses/MIT) license

[MVP.css](https://github.com/andybrewer/mvp/) uses [MIT](https://opensource.org/licenses/MIT) license