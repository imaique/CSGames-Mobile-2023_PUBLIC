# CS Games 2023 - Mobile developpement Competition

## Context

The creation of underwater cities presents a new opportunity to reimagine how residents recieve information on their enviornement. With the goals of transparency, communication and independance, the universities commitee wants to create an application that can provide information to the residents of the underwater cities.

## General overview

The unviersities commitee has mandated that your team develop a **.NET MAUI** mobile application to provide general information to residents that can assist them in their day to day activities. Specifically, the commitee would like the following information to be provided to residents : Transit schedule, local and earth wide news, temperature (water and internal), air quality, water quality and the cities power levels. Furthermore, they would like the users to recieve alerts if ever various environmental factors become a concern for their safety. Finally they would also like a feature the allows users to call for help from the application if needed.

## Technical information

A web server with an API is already in place to allow you to get the required information to display in the application

- Please take note that all information continously varies and sometimes with significant differences to facilitate testing

### Temperature information

- HTTP method : `GET`
- URL : `http://15.222.250.19/temp`
- API return : `JSON`
```
{
  "information":
  {
    "ext_water_temp":4.9,
    "int_temp":19.1
  }
}
```
- ext_water_temp : Represents the water temperature outside the city. Type `Float`
- int_temp : Represents the ambient temperature inside the city. Type `Float`

### Air quality information

- HTTP method : `GET`
- URL : `http://15.222.250.19/air`
- API return : `JSON`
```
{
  "information":
  {
    "int_air_quality":57,
  }
}
```
- int_air_quality : Represents the air quality inside the habitat. Based on the [Air Quality Index](https://www.airnow.gov/aqi/aqi-basics/). Type `Integer`

### Interior water quality information

- HTTP method : `GET`
- URL : `http://15.222.250.19/water`
- API return : `JSON`
```
{
  "information":
  {
    "int_water_quality":96,
  }
}
```
- int_water_quality : Represents the interior water quality. Based on the [Drinking Water Quality Index](https://www.gov.nl.ca/ecc/waterres/quality/drinkingwater/dwqi/). Type `Integer`


### Power level information

- HTTP method : `GET`
- URL : `http://15.222.250.19/power`
- API return : `JSON`
```
{
  "information":
  {
    "power_levels":76,
  }
}
```
- power_levels : Represents the current charge of the batteries inside the city in percentage. Type `Integer`

### News

- HTTP method : `GET`
- URL : `http://15.222.250.19/news`
- API return : `JSON`
```
{
  "news":[{
    "id":1,
    "message":"Lorem ipsum",
    "title":"Lorem ipsum",
    "type":1
  }
}
```
- id : Represents the news id. Type `Integer`
- message : Represents the news message (body). Type `String`
- title : Represents the news title (header). Type `String`
- type : Represents the type of news. `1` for local news and `2` for earth wide news. Type `Integer`


### Transit

- HTTP method : `GET`
- URL : `http://15.222.250.19/transit`
- API return : `JSON`
```
{
  "transit":[{
    "id":1,
    "frequency": 10,
    "line": 1,
    "description": "Line description",
    "schedule": "Monday : 06h00-22h30; Tuesday : 06h00-22h30; Wednesday : 06h00-22h30; Thursday : 06h00-23h00; Friday : 06h00-00h00; Saturday : 07h00-00h00; Sunday : 07h00-00h00;"
  }
}
```
- id : Represents the transit line id. Type `Integer`
- frequency : Represents the passage frequency for the line. Expressed in minutes. Type `Integer`
- line : Represents the transit line id. Type `Integer`
- description : Represents the transit line description. Type `String`
- schedule : Represents the transit line schedule. Type `String`

### SOS

- HTTP method : `POST`
- URL : `http://15.222.250.19/sos`
- CONTENT-TYPE : `application/json`
- BODY :
```
{
    "sos_signal": {
        "name":"test",
        "location":"location"
    }
}
```
- id : Name of the person calling SOS `String`
- location : Location of the person calling SOS `String`

## Comptetition value

`1400 points`

## Tasks

The application must be created using **.NET MAUI**

### Application fundamentals

- Create a basic .NET MAUI application (20 points)
- Create and use an MVVM structure (30 points)

### Data

- Connect and get the Data from the API (50 points)
- Create an efficient and easy structure to use the data recieved from the API (50 points)

### Visuals

- Develop a visual strucutre that is organized and makes the information easy to understand (400 points)
  - **You must display ALL the information provided in the technical section**
- General visual design (200 points)
- Create a splash screen (50 points)
- Support Dark and Light mode (50 points)
- Support at least two languages (50 points)
- Incorporate *Atlantis* theme (100 points)

### Functions

- Develop an SOS function that is **easy** and **safe** to use (i.e. no accidental clicks) (50 points)
- Develop a function to alert the user when the air quality changes category (50 points)
- Develop a function to alert the user when the water quality changes category (50 points)
- Develop a function to alert the user when the power levels go below 35% (50 points)
- Develop easy to use and efficient navigation system (100 points)

### General

- Code is clean and commented (25 points)
- Project runs without modifications or issues (25 points)
- Application runs quickly and fluidly (small amount of dropped frames) (50 points)
