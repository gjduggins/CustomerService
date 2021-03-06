#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY Customers.Api/Customers.Api.csproj Customers.Api/
COPY Customers.Core/Customers.Core.csproj Customers.Core/
COPY Customers.Infrastructure/Customers.Infrastructure.csproj Customers.Infrastructure/
RUN dotnet restore "Customers.Api/Customers.Api.csproj"
COPY . .
WORKDIR "/src/Customers.Api"
RUN dotnet build "Customers.Api.csproj" -c Release -o /app/build

WORKDIR "/src"
RUN dotnet test "Customers.Api.Tests/Customers.Api.Tests.csproj" --logger "trx;LogFileName=CustomerApiTests.trx" 

WORKDIR "/src/Customers.Api"
FROM build AS publish
RUN dotnet publish "Customers.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Customers.Api.dll"]
