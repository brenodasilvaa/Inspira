#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Inspira.Music.Api/Inspira.Music.Api.csproj", "Inspira.Music.Api/"]
COPY ["Inspira.Music.Infrastructure/Inspira.Music.Infrastructure.csproj", "Inspira.Music.Infrastructure/"]
COPY ["Inspira.Domain/Inspira.Domain.csproj", "Inspira.Domain/"]
RUN dotnet restore "./Inspira.Music.Api/Inspira.Music.Api.csproj"
COPY . .
WORKDIR "/src/Inspira.Music.Api"
RUN dotnet build "./Inspira.Music.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Inspira.Music.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Inspira.Music.Api.dll"]