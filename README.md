# ProductsAspNetCore

This project allows to manage local shop warehouse - availability products.

## Getting Started

These instructions describe how to prepare system (Ubuntu 16.04), run and test the project.
The project was implemented in ASP .NET MVC Core using C# language.
It's basic CRUD application using MS SQL Server for Linux and Entity Framework. 

### Prerequisites

1. Install .NET Core SDK:

```
sudo sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ xenial main" > /etc/apt/sources.list.d/dotnetdev.list'
```

```
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A0893
```

```
sudo apt-get update
```

```
sudo apt-get install dotnet-dev-1.0.3
```

2. Install MS SQL Server for Linux:

```
curl https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -
```

```
curl https://packages.microsoft.com/config/ubuntu/16.04/mssql-server.list | sudo tee /etc/apt/sources.list.d/mssql-server.list
```

```
sudo apt-get update
```

```
sudo apt-get install -y mssql-server
```

Configure MS SQL Server (enter administrative password - 'sa' user):

```
sudo /opt/mssql/bin/mssql-conf setup
```

3. Install MS SQL Server Tools (optional, include for example sqlcmd):

```
curl https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -
```

```
curl https://packages.microsoft.com/config/ubuntu/16.04/prod.list | sudo tee /etc/apt/sources.list.d/msprod.list
```

```
sudo apt-get update 
```

```
sudo apt-get install mssql-tools unixodbc-dev
```

```
echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bash_profile
```

### Installing

Clone repository to local machine and run commands:

- download packages: 

```
dotnet restore
```

- change connectionString to dabatase in appsettings.json

- run project on local port: 

```
dotnet run
```

## Built With

* [.NET Core](https://www.microsoft.com/net/core) - The .NET Framework for Windows, Linux and Mac
* [NuGet](https://www.nuget.org/) - Package Manager for Microsoft development platform

## Author

* **Krzysztof Goljasz**

See also the list of [contributors](https://github.com/ChristopherGol/ProductsAspNetCore/graphs/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details