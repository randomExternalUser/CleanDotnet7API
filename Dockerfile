#Build Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source
COPY . .
RUN dotnet restore "src/CleanDotnet7API.Api/CleanDotnet7API.Api.csproj" --disable-parallel
RUN dotnet publish "src/CleanDotnet7API.Api/CleanDotnet7API.Api.csproj" -c release -o /app --no-restore

# #Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
COPY --from=build /app ./

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "CleanDotnet7API.Api.dll"]