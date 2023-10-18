using Azure.Core;
using Azure.Messaging.WebPubSub;

var connectionString = "Endpoint=https://doki-pubsub.webpubsub.azure.com;AccessKey=s/Cwq8jMhRf94n2tQZ09FDavmoxuDuF61eho75qbAa8=;Version=1.0;";
var hubName = "doki_hub";
var serviceClient = new WebPubSubServiceClient(connectionString, hubName);

int index = 0;
while (true)
{
    serviceClient.SendToAll(RequestContent.Create(new { Foo = $"Hello Doki Notif: {index++}" }), ContentType.ApplicationJson);
    Thread.Sleep(1000);
}