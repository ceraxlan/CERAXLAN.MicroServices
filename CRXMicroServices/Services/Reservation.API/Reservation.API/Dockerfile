#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Reservation.API/Reservation.API/Reservation.API.csproj", "Services/Reservation.API/Reservation.API/"]
COPY ["Reservation.API/Reservation.API.Infrastructure/Reservation.API.Infrastructure.csproj", "Reservation.API/Reservation.API.Infrastructure/"]
COPY ["Services/Reservation.API/Reservation.API.Models/Reservation.API.Models.csproj", "Services/Reservation.API/Reservation.API.Models/"]
COPY ["Services/Contact.API/Contact.Service/Contact.API.Service.csproj", "Services/Contact.API/Contact.Service/"]
COPY ["Services/Contact.API/Contact.API.Infrastructure/Contact.API.Infrastructure.csproj", "Services/Contact.API/Contact.API.Infrastructure/"]
COPY ["Services/Contact.API/Contact.API.Models/Contact.API.Models.csproj", "Services/Contact.API/Contact.API.Models/"]
COPY ["Services/Reservation.API/Reservation.API.Service/Reservation.API.Service.csproj", "Services/Reservation.API/Reservation.API.Service/"]
RUN dotnet restore "Services/Reservation.API/Reservation.API/Reservation.API.csproj"
COPY . .
WORKDIR "/src/Services/Reservation.API/Reservation.API"
RUN dotnet build "Reservation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reservation.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reservation.API.dll"]