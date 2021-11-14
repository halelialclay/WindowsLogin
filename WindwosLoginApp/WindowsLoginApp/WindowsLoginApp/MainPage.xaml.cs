using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;


namespace WindwosLoginApp
{
    public partial class MainPage : ContentPage
    {
        private string phoneId = DependencyService.Get<IGetDeviceInfo>().GetDeviceID();



        public MainPage()
        {
            InitializeComponent();
            GUID.IsVisible = false;
            newPass.IsVisible = false;
        }


        private void getIDClicked(object sender, EventArgs e)
        {
            /*
            string urlBase = "http://10.0.2.2:2612/";
            string sUrl = urlBase + "api/Guid";
            string response = "11111";
            using (var client = new WebClient())
            {
                client.Headers.Add("content-type", "application/json");
                 response = client.DownloadString(sUrl);
            }
            */
            newID.Text = phoneId;
        }

        private void sendNewPass(object sender, EventArgs e)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int ticks = rnd.Next(000000, 999999);
            string mySplit = "$$$";

            string urlBase = "https://haleli.bemazaltov.co.il/";
            string sUrl = urlBase + "api/saveNewPass";
            string id = phoneId;
            //string sendData = "=" + id + mySplit + pass.Text + mySplit + ticks;

            string json = "{id:\"" + id + "\", password:\"" + pass.Text + "\", ticks:\"" + ticks + "\"}";
            var vm = new { id = id, password = pass.Text, ticks = ticks.ToString() };
            var dataString = JsonConvert.SerializeObject(vm);
            using (WebClient cli = new WebClient())
            {
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";
                cli.UploadString(sUrl, "POST", dataString);
            }

            OneTimePass.Text = ticks.ToString();
           /* string message = "Your password for the next 5 min:" + ticks.ToString();
            Chat.Open("972586099315", message);*/
            
        }

        private void hadingNewPassClicked(object sender, EventArgs e)
        {
            newPass.IsVisible = true;
            GUID.IsVisible = false;

        }

        private void hadingGetIdClicked(object sender, EventArgs e)
        {
            GUID.IsVisible = true;
            
            newPass.IsVisible = false;


        }

       
    }
   
}
