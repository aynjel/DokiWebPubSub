using Azure.Messaging.WebPubSub;
using Microsoft.AspNetCore.Mvc;

namespace dokiwebpubsub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PubSubController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var connectionString = "Endpoint=https://doki-pubsub.webpubsub.azure.com;AccessKey=s/Cwq8jMhRf94n2tQZ09FDavmoxuDuF61eho75qbAa8=;Version=1.0;";
            var hubName = "doki_hub";
            var serviceClient = new WebPubSubServiceClient(connectionString, hubName);
            var uri = serviceClient.GetClientAccessUri(TimeSpan.FromHours(1));
            return Ok(new { uri });
        }
    }
}