#Use your choice of image as base. Mine is alpine! 
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app

FROM  mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY . .

RUN dotnet restore "src/AuthGuard.Api/AuthGuard.Api.csproj"
WORKDIR "/src/."
COPY . .
RUN dotnet build "src/AuthGuard.Api/AuthGuard.Api.csproj" -c Release -o /app/build

FROM build as publish
RUN dotnet publish "src/AuthGuard.Api/AuthGuard.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthGuard.Api.dll"]