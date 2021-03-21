FROM mcr.microsoft.com/dotnet/sdk:5.0
# copy files from repo to new 'sharpChain' folder
COPY . ./sharpchain/
WORKDIR /sharpchain/
RUN dotnet restore

#compile and set an entry point
RUN dotnet build -c Release
ENTRYPOINT ["dotnet", "run", "-c", "Release", "--no-build"]