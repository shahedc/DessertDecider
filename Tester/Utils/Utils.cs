using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Tester.Utils
{
    public static class ApiCaller
    {
        const string PointsUrl = "http://dessertweb.azurewebsites.net/api/Points";
        const string DecideUrl = "http://dessertweb.azurewebsites.net/api/Decide";
        public static int GetNumericPoints()
        {
            int points;
            using (WebClient client = new WebClient())
            {
                points = Convert.ToInt32(client.DownloadString(PointsUrl));
            }
            return points;
        }
        public static bool GetBoolDecision()
        {
            bool decision ;
            using (WebClient client = new WebClient())
            {
                decision = Convert.ToBoolean(client.DownloadString(DecideUrl));
            }
            return decision;
        }
    }
}
