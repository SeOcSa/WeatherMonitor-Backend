# WeatherMonitor-Backend
## Setup
- Install NET Core SDK 3.0
- Install/Configure a MariaDB >= 10.3 database (version 10.3 or higher)
- Import data from weatherforecast_weatherforecasts.json I'm using DataGrip ( optional )
- To have data use frontend and type a city name.
- To see a history of search you have to change a CreatedDateTime for an registration or wait till next day.
## Dev
 ### Run
- Generate Migration: dotnet ef migrations add migration_name ApplicationDbContext
- Update Database: dotnet ef database update ApplicationDbContext
- ConnectionStrings
 - TestManagerMariaDb - server=localhost;port=3308;database=weatherforecast;uid=root;password=DATABASEUSERPASSWORD;Persist Security Info=True;Convert Zero Datetime=True;charset=utf8
ALLOWED_CORS_HOSTS - URL_FOR_FRONTEND_APPLICATION
### Logging
- LogLevel:Default - Info
- LogLevel:System - Warning
- LogLevel:Microsoft - none
### Deploy/Access
#### Access
- /swagger for swagger
- /api/Weather/[action] for api
