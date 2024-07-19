FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/BankStatement.Web.Mvc/BankStatement.Web.Mvc.csproj", "src/BankStatement.Web.Mvc/"]
COPY ["src/BankStatement.Web.Core/BankStatement.Web.Core.csproj", "src/BankStatement.Web.Core/"]
COPY ["src/BankStatement.Application/BankStatement.Application.csproj", "src/BankStatement.Application/"]
COPY ["src/BankStatement.Core/BankStatement.Core.csproj", "src/BankStatement.Core/"]
COPY ["src/BankStatement.EntityFrameworkCore/BankStatement.EntityFrameworkCore.csproj", "src/BankStatement.EntityFrameworkCore/"]
WORKDIR "/src/src/BankStatement.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/BankStatement.Web.Mvc", "src/BankStatement.Web.Mvc"]
COPY ["src/BankStatement.Web.Core", "src/BankStatement.Web.Core"]
COPY ["src/BankStatement.Application", "src/BankStatement.Application"]
COPY ["src/BankStatement.Core", "src/BankStatement.Core"]
COPY ["src/BankStatement.EntityFrameworkCore", "src/BankStatement.EntityFrameworkCore"]
WORKDIR "/src/src/BankStatement.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "BankStatement.Web.Mvc.dll"]
