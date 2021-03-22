using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using DummyLib;

namespace dotnet5isolated
{
    public static class HttpTrigger
    {
        [Function("HttpTrigger")]
        public static HttpResponseData Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req,
            [DummyInput(DummyName="foo")] DummyObject dummyObject,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("HttpTrigger");
            logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content", "Content - Type: text / html; charset = utf - 8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
