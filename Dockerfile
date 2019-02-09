FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS publish
WORKDIR /src
COPY ["src/", "/src/"]
RUN dotnet restore "Ldv.PersonalSite.csproj"
RUN dotnet publish "Ldv.PersonalSite.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ldv.PersonalSite.dll"]
