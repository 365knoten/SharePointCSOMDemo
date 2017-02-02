using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointCSOMDemo.Demo
{
    public class AttachFile
    {

        public static void attachFile(ListItem item, ClientContext ctx, String filepath) {

            var attInfo = new AttachmentCreationInformation();
            attInfo.FileName = Path.GetFileName(filepath);
            attInfo.ContentStream = new MemoryStream(System.IO.File.ReadAllBytes(filepath));

            Attachment att = item.AttachmentFiles.Add(attInfo); //Add to File

            ctx.Load(att);
            ctx.ExecuteQuery();
        }

    }
}
