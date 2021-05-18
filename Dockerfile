FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build

WORKDIR /app
COPY GrpcHang.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -o out -c Release

FROM mcr.microsoft.com/dotnet/core/runtime:3.1 as runtime
WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT ["./GrpcHang"]
