# LAMBDA LOCAL TESTING




## links

- nugget Amazon.Lambda.TestTool [https://www.nuget.org/packages/Amazon.Lambda.TestTool-3.1]
- github LambdaTestTool [https://github.com/aws/aws-lambda-dotnet/tree/master/Tools/LambdaTestTool]

## Files

- aws-lambda-tools-defaults: [PROJECT]/

- launchSettings.json: PATH [PROJECT]/Properties

- serverless.yml: PATH [PROJECT]/

### EXAMPLES

### aws-lambda-tools-defaults

```json
#
{
    "profile":"default",
    "region" : "us-east-1",
    "configuration": "Release",
    "framework": "netcoreapp3.1",
    "template": "serverless.yml"
}
```

### launchSettings.json

```json
{
  "profiles": {
    "aws-csharp": {
      "commandName": "Project",
      "commandLineArgs": "debug"
    },
    "Profile 1": {
      "commandName": "Executable",
      "executablePath": "%USERPROFILE%\\.dotnet\\tools\\dotnet-lambda-test-tool-3.1.exe",
      "commandLineArgs": "--port 5050",
      "workingDirectory": ".\\bin\\$(Configuration)\\netcoreapp3.1"
    }
  }
}
```

### serverless.yml

``` yml
service: tmpApi # NOTE: update this with your service name
provider:
  name: aws
  runtime: dotnetcore3.1
  stage: tmpApidev
  region: us-east-1
package:
  individually: true
  artifact: bin/release/netcoreapp3.1/hello.zip
functions:
  hello:
    handler: CsharpHandlers::CsharpHandlers.Functions.CreateWithDrawallHandler::Run
    events:
      - http:
          path: items
          method: get
    environment:
      variable2: value2
```


## Test in Windows

```cmd
dotnet tool install --global Amazon.Lambda.TestTool-3.1 --version 0.11.3
dotnet publish -c debug
dotnet lambda-test-tool-3.1 --config-file aws-lambda-tools-defaults.json
```

