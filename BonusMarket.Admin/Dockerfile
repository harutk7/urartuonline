﻿#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /
COPY ["./BonusMarket.Admin/BonusMarket.Admin.csproj", "BonusMarket.Admin/"]
COPY ["./BonusMarket.Shared/BonusMarket.Shared.csproj", "BonusMarket.Shared/"]
RUN dotnet restore "BonusMarket.Admin/BonusMarket.Admin.csproj"
COPY ./ .
WORKDIR "/BonusMarket.Admin"
RUN dotnet build "BonusMarket.Admin.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BonusMarket.Admin.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BonusMarket.Admin.dll"]
