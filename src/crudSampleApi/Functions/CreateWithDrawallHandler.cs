using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CsharpHandlers.Functions
{

    public class CreateWithDrawallHandler
    {
        IConfiguration config;
        public CreateWithDrawallHandler(): this(new StartUp().BuildConfig(new ServiceCollection()))
        {

        }

        public CreateWithDrawallHandler(IConfiguration config)
        {
            this.config = config;
        }

        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public async Task<APIGatewayProxyResponse> Run(APIGatewayProxyRequest request)
        {
            // var requestModel = JsonConvert.DeserializeObject<UpdateItemRequest>(request.Body);

            // var result = await mediator.Send(requestModel);var

           var hello= config["secretKey"];


            string result = await Task.Run(() => { return hello; });

            return new APIGatewayProxyResponse { StatusCode = 200, Body = JsonConvert.SerializeObject(result) };
        }
    }
}
