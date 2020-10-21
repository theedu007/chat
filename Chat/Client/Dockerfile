FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY Chat.Client.csproj .
RUN dotnet restore "Chat.Client.csproj"
COPY . .
RUN dotnet build "Chat.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chat.Client.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf