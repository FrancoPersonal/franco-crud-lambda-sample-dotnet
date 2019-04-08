using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHandlers.Functions
{
    
    public class CreateWithDrawallHandler
    {
        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public async Task<APIGatewayProxyResponse> Run(APIGatewayProxyRequest request)
        {
            // var requestModel = JsonConvert.DeserializeObject<UpdateItemRequest>(request.Body);

            // var result = await mediator.Send(requestModel);var 

            var result = await Task.Run(() => { return "Hello Get"; });

            return new APIGatewayProxyResponse { StatusCode = 200, Body = JsonConvert.SerializeObject(result) };
        }



    }
}
