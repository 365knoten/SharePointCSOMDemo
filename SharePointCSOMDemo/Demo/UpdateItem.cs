using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointCSOMDemo.Demo
{
    public class UpdateItem
    {
        public static void  updateState(ListItem item, ClientContext ctx, string state) {

            item["Status"] = state;
            item.Update();
            ctx.ExecuteQuery();


        }

    }
}
