using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web.UI;

namespace GoogleAuthWebApp
{
    public partial class _Default : Page
    {
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Google Drive API Demo by MS19803876";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            UserCredential credential;
            String path = Server.MapPath("~/App_Data/client_secret.json");
            using (var stream =
                 new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                     System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                     GoogleClientSecrets.Load(stream).Secrets,
                     Scopes,
                     "user",
                     CancellationToken.None,
                     new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                 .Files;
            ListBox1.Items.Clear();
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    ListBox1.Items.Add(file.Name+" | "+file.FileExtension + " | " + file.Size);
                }
            }
            else
            {
                ListBox1.Items.Add("No files found.");
            }

        }
    }

}