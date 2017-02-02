using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static SharePointCSOMDemo.Demo.Settings;

namespace SharePointCSOMDemo.Demo
{

    // All Authentication Methods
    //http://www.ktskumar.com/2016/05/authenticate-sharepoint-using-pnp-authentication-manager/


    public class Authentication
    {

      

        /// <summary>
        /// Authenticate using a given UserName and Password... Not the best Idea to store password in clear text
        /// </summary>
        public static ClientContext authenticateWithUserNamePassword()
        {


            OfficeDevPnP.Core.AuthenticationManager authMgr = new OfficeDevPnP.Core.AuthenticationManager();

            return authMgr.GetSharePointOnlineAuthenticatedContextTenant(siteURL, username, password);
        }


        /// <summary>
        /// Ask the User for his Credentials.... Not the best idea in automated Scripts
        /// </summary>
        public static ClientContext authenticateByAskingUser()
        {

            OfficeDevPnP.Core.AuthenticationManager authMgr = new OfficeDevPnP.Core.AuthenticationManager();

            return authMgr.GetWebLoginClientContext(siteURL);
        }


        /// <summary>
        /// Get the credentials from Windows Secure Store... Good, i use that often
        /// </summary>
        public static ClientContext authenticateByWindowsSecureStore()
        {
          

            OfficeDevPnP.Core.AuthenticationManager authMgr = new OfficeDevPnP.Core.AuthenticationManager();

            NetworkCredential cred = OfficeDevPnP.Core.Utilities.CredentialManager.GetCredential(securestoreid);
            return authMgr.GetSharePointOnlineAuthenticatedContextTenant(siteURL, cred.UserName, cred.SecurePassword);

        }


        /// <summary>
        /// Authenticate using App Only Credentials... Good, i use that often
        /// </summary>
        public static ClientContext authenticateByAppOnlyCredentials()
        {
            // Using App Secret
            // More Info see here
            // http://www.thesharepointguide.com/access-office-365-using-a-console-application/


            OfficeDevPnP.Core.AuthenticationManager authMgr = new OfficeDevPnP.Core.AuthenticationManager();

            return authMgr.GetAppOnlyAuthenticatedContext(siteURL, appId, appSecret);

        }


    }
}
