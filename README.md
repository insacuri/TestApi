# TestApi
Test API written in C#

## Docker

In the root of the project

```
docker build -f TestApi/Dockerfile -t testapi .
docker run -d -p 5000:80 --name testapi testapi
```