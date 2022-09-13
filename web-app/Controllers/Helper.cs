using System;
namespace web_app.Controllers
{
    public class Helper
    {
        public void initialize()
        {
            string filepath = @"credentials.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
        }
    }
}

