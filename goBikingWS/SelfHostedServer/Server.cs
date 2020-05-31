using System;
using System.IO;
using System.Threading;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using goBikingWCFClient;



namespace SelfHostedServer
{
    class Server
    {
        private string Port = "9090";
        // Web Server used to host services
        private ServiceHost Host;

        /**
         * Start the web server on the given port, and host the expected service
         */
        public void start()
        {
            Console.WriteLine("Starting a WCF self-hosted .Net server... ");
            string url = "http://" + "localhost" + ":" + Port + "/ServiceClient";

            Host = new ServiceHost(typeof(ServiceClient), new Uri(url));

            // Adding the service to the host
            //SOAP
            BasicHttpBinding soapbinding = new BasicHttpBinding();
            soapbinding.MaxReceivedMessageSize = 10000000;
            soapbinding.MaxBufferSize = 10000000;
            soapbinding.MaxBufferPoolSize = 10000000;
            soapbinding.ReaderQuotas.MaxDepth = 32;

            Host.AddServiceEndpoint(typeof(IServiceClient), soapbinding, "soap");

            //REST

            WebHttpBinding restbinding = new WebHttpBinding();
            restbinding.MaxReceivedMessageSize = 10000000;
            restbinding.MaxBufferSize = 10000000;
            restbinding.MaxBufferPoolSize = 10000000;
            restbinding.ReaderQuotas.MaxDepth = 32;

            ServiceEndpoint restEndpoint = Host.AddServiceEndpoint(typeof(IServiceClient), restbinding, "rest");
            restEndpoint.Behaviors.Add(new WebHttpBehavior());


            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            Host.Description.Behaviors.Add(smb);

            // Staring the Host server
            Host.Open();
            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("\nListening to " + url + "\n");
            refreshData();
            interactive();

        }

        /**
         * Stop the web server
         */
        private void stop()
        {
            Host.Close();
            Console.WriteLine("Server shutdown complete!");
        }

        /**
         * Start the server in interactive mode, waiting for Return to
         */
        private void interactive()
        {
            Console.WriteLine("Hit Return to shutdown the server.");
            Console.ReadLine();
            stop();
        }

        /**
         * Send the request to JCDecaux service in order to refresh data every 5 min
         */
        private void refreshData()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(5);

            var timer = new System.Threading.Timer((e) =>
            {
                ServiceClient.refreshData();
            }, null, startTimeSpan, periodTimeSpan);

        }

        /**
         * Main method
         */
        public static void Main(string[] args)
        {
            var server = new Server();
            server.start();
        }

    }
}
