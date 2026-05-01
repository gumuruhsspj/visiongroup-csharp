# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Stage 2: Runtime (Ringan banget)
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 5200
ENV ASPNETCORE_URLS=http://+:5200
ENTRYPOINT ["dotnet", "csharp-websocket.dll"]