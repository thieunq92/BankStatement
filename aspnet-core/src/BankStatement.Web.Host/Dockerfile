FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/BankStatement.Web.Host/BankStatement.Web.Host.csproj", "src/BankStatement.Web.Host/"]
COPY ["src/BankStatement.Web.Core/BankStatement.Web.Core.csproj", "src/BankStatement.Web.Core/"]
COPY ["src/BankStatement.Application/BankStatement.Application.csproj", "src/BankStatement.Application/"]
COPY ["src/BankStatement.Core/BankStatement.Core.csproj", "src/BankStatement.Core/"]
COPY ["src/BankStatement.EntityFrameworkCore/BankStatement.EntityFrameworkCore.csproj", "src/BankStatement.EntityFrameworkCore/"]
WORKDIR "/src/src/BankStatement.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/BankStatement.Web.Host", "src/BankStatement.Web.Host"]
COPY ["src/BankStatement.Web.Core", "src/BankStatement.Web.Core"]
COPY ["src/BankStatement.Application", "src/BankStatement.Application"]
COPY ["src/BankStatement.Core", "src/BankStatement.Core"]
COPY ["src/BankStatement.EntityFrameworkCore", "src/BankStatement.EntityFrameworkCore"]
WORKDIR "/src/src/BankStatement.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "BankStatement.Web.Host.dll"]
