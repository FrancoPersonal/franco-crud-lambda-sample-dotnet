# codebuild local

url: [https://docs.aws.amazon.com/codebuild/latest/userguide/use-codebuild-agent.html]

## prerequisites

- [docker](https://www.docker.com/products/docker-desktop)
- [netcore sdk ubuntuu](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu)

## install

### Local

``` cmd
git clone https://github.com/aws/aws-codebuild-docker-images.git
cd aws-codebuild-docker-images/ubuntu/standard/5.0
docker build -t aws/codebuild/standard:5.0 .

```

### WSL

``` batch
# in repo folder src
wget https://raw.githubusercontent.com/aws/aws-codebuild-docker-images/
master/local_builds/codebuild_build.sh
chmod +x codebuild_build.sh

docker pull public.ecr.aws/codebuild/local-builds:latest
mkdir out
./codebuild_build.sh -i aws/codebuild/standard/5.0 -a out -b crud_lambda/infra

```
