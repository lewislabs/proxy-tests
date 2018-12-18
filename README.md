docker network create -d bridge --subnet=169.254.169.0/24 aws-proxy-network
cd app1
docker build -t app1:latest .
cd ../proxy
docker build -t aws-proxy:latest .
docker run -d -p 80:5000 --name=aws-proxy --network=aws-proxy-network --ip=169.254.169.254 aws-proxy:latest
docker run --network=aws-proxy-network app1:latest
prints
```
Hello world! <- response from the proxy container
Hello world! <- console out from app1
```