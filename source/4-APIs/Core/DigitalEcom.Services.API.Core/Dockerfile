#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["source/4-APIs/Core/DigitalEcom.Services.API.Core/DigitalEcom.Services.API.Core.csproj", "source/4-APIs/Core/DigitalEcom.Services.API.Core/"]
RUN dotnet restore "source/4-APIs/Core/DigitalEcom.Services.API.Core/DigitalEcom.Services.API.Core.csproj"
COPY . .
WORKDIR "/src/source/4-APIs/Core/DigitalEcom.Services.API.Core"
RUN dotnet build "DigitalEcom.Services.API.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DigitalEcom.Services.API.Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DigitalEcom.Services.API.Core.dll"]