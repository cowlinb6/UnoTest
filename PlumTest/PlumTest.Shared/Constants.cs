using System;
using System.Collections.Generic;
using System.Text;

namespace Plum.Common
{
    public static class Constants
    {
        //public static string AuthorityUri = "http://cloud.idp:5001";
        //public static string AuthorityUri = "https://login.xarios.dev";
        public static string AuthorityUri = "https://benlogin.ngrok.io";
        public static string RedirectUri = "plum.oauth2:/oauth2redirect";
        public static string ApiUri = "https://demo.identityserver.io/api/";
        public static string ClientId = "plum";
        public static string Scope = "openid offline_access";
    }
}
