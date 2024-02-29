FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/WebHMI.Web.Host/WebHMI.Web.Host.csproj", "src/WebHMI.Web.Host/"]
COPY ["src/WebHMI.Web.Core/WebHMI.Web.Core.csproj", "src/WebHMI.Web.Core/"]
COPY ["src/WebHMI.Application/WebHMI.Application.csproj", "src/WebHMI.Application/"]
COPY ["src/WebHMI.Core/WebHMI.Core.csproj", "src/WebHMI.Core/"]
COPY ["src/WebHMI.EntityFrameworkCore/WebHMI.EntityFrameworkCore.csproj", "src/WebHMI.EntityFrameworkCore/"]
WORKDIR "/src/src/WebHMI.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/WebHMI.Web.Host", "src/WebHMI.Web.Host"]
COPY ["src/WebHMI.Web.Core", "src/WebHMI.Web.Core"]
COPY ["src/WebHMI.Application", "src/WebHMI.Application"]
COPY ["src/WebHMI.Core", "src/WebHMI.Core"]
COPY ["src/WebHMI.EntityFrameworkCore", "src/WebHMI.EntityFrameworkCore"]
WORKDIR "/src/src/WebHMI.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "WebHMI.Web.Host.dll"]


