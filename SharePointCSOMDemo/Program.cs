using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharePointCSOMDemo
{
    class Program
    {



        static void Main(string[] args)
        {

            // First we need to log in
            //using (var ctx = Demo.Authentication.authenticateWithUserNamePassword() )
            //using (var ctx = Demo.Authentication.authenticateByAskingUser())            
            //using (var ctx = Demo.Authentication.authenticateByAppOnlyCredentials())
            using (var ctx = Demo.Authentication.authenticateByWindowsSecureStore())
            {

                // First Load the Web
                ctx.Load(ctx.Web);
                // But the upper command does nothing, we have to execute the query first
                ctx.ExecuteQuery();
                               
                // Now we can use the web Object
                System.Console.WriteLine($"Connected to Website {ctx.Web.Title}");



                // Query List Data
                //foreach (ListItem item in Demo.Query.query(ctx))
                //{

                    // For each Element in the List, dump it
                    // Demo.DumpRequirement.logSimple(item);
                    // Demo.DumpRequirement.log(item);

                    // Now do something in the ERP System.... not covered in this Example

                    // Attach the PDF
                    //Demo.AttachFile.attachFile(item, ctx, "Demo\\Bestellung.pdf");

                    // Update Item State
                    //Demo.UpdateItem.updateState(item, ctx, "Rechnung eingegangen");


                //}



            }

            System.Console.WriteLine("Done");
            System.Console.ReadLine();


        }




    }
}
