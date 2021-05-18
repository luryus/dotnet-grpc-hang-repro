Usage
=====

#### Run locally

Run in bash:

```
dotnet publish -c Release -o out
while true ; do out/GrpcHang ; done
```

Should hang in a few iterations.



#### Run in Docker

Run in bash:

```
docker build -t grpchang .
while true; do docker run -i -t --rm grpchang ; done
```
