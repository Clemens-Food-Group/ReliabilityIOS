using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.clemensfoods.attendance.Models;
using Flurl.Http;
using Xamarin.Forms;

namespace com.clemensfoods.attendance.Services
{
    public class REST
    {

        public List<AttendanceModel> RestService(Entry TimeCard)
        {

            // This line disables SSL verification
            //System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicy) => { return true; };

            using (var client = new FlurlClient("https://cfgazure.azurewebsites.net"))
            {
                try
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicy) => { return true; };
                    var result = client.Request("Reliability/GetCurrentMonthReliability")
                        .SetQueryParam("TimeCardID",TimeCard.Text)
                        //.SetQueryParam()
                        .GetJsonAsync<List<AttendanceModel>>().Result;





                    return result;

                }
                catch (FlurlHttpException fe)
                {
                    var error = fe;


                    //var properties = new Dictionary<string, string>
                    //{
                    //    { "REST", "RegisterPushTokenRequest" },
                    //    { "Error", "Fluent URL"}
                    //};
                    //Crashes.TrackError(fe, properties);

                    return null;
                }
                catch (Exception e)
                {
                    var v = e;
                    //var properties = new Dictionary<string, string>
                    //{
                    //    { "Services.RegisterPushNotificatons", "RegisterPushTokenRequest" },
                    //    { "Error", "Fluent URL"}
                    //};
                    //Crashes.TrackError(e, properties);

                    ///
                    /// send a TOAST message here
                    /// 
                    return null;
                }
            }
        }
    }
}
    