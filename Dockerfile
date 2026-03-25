FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["FowCampaign.Api/FowCampaign.Api.csproj", "FowCampaign.Api/"]
RUN dotnet restore "FowCampaign.Api/FowCampaign.Api.csproj"
COPY . .
WORKDIR "/src/FowCampaign.Api"
RUN dotnet build "./FowCampaign.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./FowCampaign.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FowCampaign.Api.dll"]
