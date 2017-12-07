using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace bot.Utils
{
    public static class ApiCaller
    {
        public const int MaxPoints = 10;
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
            bool decision;
            using (WebClient client = new WebClient())
            {
                decision = Convert.ToBoolean(client.DownloadString(DecideUrl));
            }
            return decision;
        }

        public static object GetMaxPoints()
        {
            return MaxPoints;
        }
    }
}