using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointCSOMDemo.Demo
{
    public class DumpRequirement
    {


        public static void logSimple(ListItem oListItem) {

            Console.WriteLine("###############################################");
            Console.WriteLine($"Bedarfsanforderung No. {oListItem.Id}");

            Console.WriteLine($"Title: {oListItem["Title"]}");
            Console.WriteLine($"Anzahl: {oListItem["Anzahl"]}");
            Console.WriteLine($"Stueckpreis: {oListItem["Stueckpreis"]}");
            Console.WriteLine($"Endpreis: {oListItem["Endpreis"]}");
            Console.WriteLine($"Status: {oListItem["Status"]}");


            Console.WriteLine($"Gerätetyp: {oListItem["Ger_x00e4_tetyp"]}");           
            Console.WriteLine($"Zulieferer: {oListItem["Zulieferer"]}");

            Console.WriteLine();

        }



        public static void log(ListItem oListItem)
        {

            Console.WriteLine("###############################################");
            Console.WriteLine($"Bedarfsanforderung No. {oListItem.Id}");

            Console.WriteLine($"Title: {oListItem["Title"]}");
            Console.WriteLine($"Anzahl: {oListItem["Anzahl"]}");
            Console.WriteLine($"Stueckpreis: {oListItem["Stueckpreis"]}");
            Console.WriteLine($"Endpreis: {oListItem["Endpreis"]}");
            Console.WriteLine($"Status: {oListItem["Status"]}");


            //Console.WriteLine($"Gerätetyp: {oListItem["Ger_x00e4_tetyp"]}");
            Dictionary<String, Object> geraetetyp = (Dictionary<String, Object>)oListItem["Ger_x00e4_tetyp"];
            Console.WriteLine(geraetetyp["Label"]);

            //Console.WriteLine($"Zulieferer: {oListItem["Zulieferer"]}");
            FieldLookupValue zulieferer = (FieldLookupValue)oListItem["Zulieferer"];
            Console.WriteLine($"Zulieferer: {zulieferer.LookupValue}");



            Console.WriteLine();

        }



    }
}
