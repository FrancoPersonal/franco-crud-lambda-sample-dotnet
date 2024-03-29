#!/bin/bash

#install zip on debian OS, since microsoft/dotnet container doesn't have zip by default
if [ -f /etc/debian_version ]
then
  apt -qq update
  apt -qq -y install zip
fi

dotnet restore
cd crudSampleApi
dotnet lambda package --configuration release --framework netcoreapp3.1 --output-package bin/release/netcoreapp3.1/hello.zip
