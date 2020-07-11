using System;
using System.Text;

namespace Winter
{
    public static class ApplicationKeys
    {
        public static string clientid = "";
        public static string clientsecret = "";
        public static string Spotify = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", clientid, clientsecret)));
    }
}
