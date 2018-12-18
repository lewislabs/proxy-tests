FROM microsoft/dotnet:2.2-sdk
RUN mkdir /src
COPY app1.csproj /src/
COPY *.cs /src/
WORKDIR /src
ENTRYPOINT [ "dotnet", "run" ]