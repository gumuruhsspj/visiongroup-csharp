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
EXPOSE 5188
ENV ASPNETCORE_URLS=http://+:5188
ENTRYPOINT ["dotnet", "csharp-restapi.dll"]