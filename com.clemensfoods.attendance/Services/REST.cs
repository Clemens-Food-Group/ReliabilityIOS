using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.clemensfoods.attendance.Models;
using Flurl.Http;

namespace com.clemensfoods.attendance.Services
{
    public class REST
    {

        public List<AttendanceModel> RestService()
        {

            // This line disables SSL verification
            //System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicy) => { return true; };

            using (var client = new FlurlClient("{BASE URL HERE}"))
            {
                try
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicy) => { return true; };
                    var result = client.Request("{REQUEST HERE 'request/service' }")
                        //.SetQueryParam()
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
    