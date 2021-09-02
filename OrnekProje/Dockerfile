#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /OrnekProje


COPY *.csproj .
RUN ["dotnet", "restore"]
COPY . ./
RUN ["dotnet", "build"]

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /OrnekProje
COPY --from=base /OrnekProje/out .
ENTRYPOINT ["dotnet", "OrnekProje.dll"]

