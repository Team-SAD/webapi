FROM mcr.microsoft.com/dotnet/sdk as base

WORKDIR /app
COPY . .
RUN dotnet publish --configuration Release -o out Planner.Client

FROM mcr.microsoft.com/dotnet/aspnet

WORKDIR /run
COPY --from=base /app/out .
CMD [ "dotnet", "Planner.Client.dll" ]