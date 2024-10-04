# Stage 1: Build the application in a .NET 8 SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy everything into the container
COPY . ./

# Add Syncfusion.Pivot.Engine NuGet package (specific version)
RUN dotnet add package Syncfusion.Pivot.Engine --version 27.1.50

# Restore any dependencies
RUN dotnet restore

# Build and publish a release
RUN dotnet publish -c Release -o out

# Stage 2: Create a runtime image with .NET 8 runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App

# Copy the published output from the build stage
COPY --from=build-env /App/out .

# Expose port 8080
EXPOSE 8080

# Set the correct DLL name in the entry point
ENTRYPOINT ["dotnet", "PivotController.dll"]
