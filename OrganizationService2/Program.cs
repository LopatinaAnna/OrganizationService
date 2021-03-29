using System;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Tooling.Connector;

namespace OrganizationService2
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://annaenvironment.crm4.dynamics.com/";
            string userName = "admin@annalopatina123456.onmicrosoft.com";
            string password = "Th13vjktyrj-";

            string conn = $@"
    Url = {url};
    AuthType = OAuth;
    UserName = {userName};
    Password = {password};
    AppId = 51f81489-12ee-4a9e-aaae-a2591f45987d;
    RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97;
    LoginPrompt=Auto;
    RequireNewInstance = True";

            using (var svc = new CrmServiceClient(conn))
            {

                WhoAmIRequest request = new WhoAmIRequest();

                WhoAmIResponse response = (WhoAmIResponse)svc.Execute(request);

                Console.WriteLine("Your UserId is {0}", response.UserId);

                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            }
        }
    }
}
