FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/ExampleApp.Api/ExampleApp.Api.csproj", "src/ExampleApp.Api/"]
RUN dotnet restore "src/ExampleApp.Api/ExampleApp.Api.csproj"
COPY . .
WORKDIR "/src/src/ExampleApp.Api"
RUN dotnet build "ExampleApp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExampleApp.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExampleApp.Api.dll"]
