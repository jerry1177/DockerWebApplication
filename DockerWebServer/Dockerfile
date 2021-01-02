#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DockerWebServer/DockerWebServer.csproj", "DockerWebServer/"]
RUN dotnet restore "DockerWebServer/DockerWebServer.csproj"
COPY . .
WORKDIR "/src/DockerWebServer"
RUN dotnet build "DockerWebServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerWebServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerWebServer.dll"]