FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "Chat/Server/Chat.Server.csproj"
RUN dotnet build "Chat/Server/Chat.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chat/Server/Chat.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Chat.Server.dll