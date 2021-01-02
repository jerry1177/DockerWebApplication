#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["WebService2/WebService2.csproj", "WebService2/"]
RUN dotnet restore "WebService2/WebService2.csproj"
COPY . .
WORKDIR "/src/WebService2"
RUN dotnet build "WebService2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebService2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebService2.dll"]