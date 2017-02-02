using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointCSOMDemo.Demo
{
    public class Query
    {

        public static ListItemCollection query(ClientContext ctx ) {



            List list = ctx.Web.Lists.GetByTitle("Bedarf");


            CamlQuery camlQuery = new CamlQuery();
            camlQuery.ViewXml = $@"<View>
                                            <Query>
                                                <Where>
                                                    <Eq>
                                                        <FieldRef Name='Status'/>
                                                        <Value Type='Choice'>Genehmigt</Value>
                                                    </Eq>
                                                </Where>
                                            </Query>
                                        <RowLimit>100</RowLimit>
                                    </View>";

            ListItemCollection collListItem = list.GetItems(camlQuery);

            ctx.Load(collListItem);

            ctx.ExecuteQuery();

            return collListItem;

        }

    }
}
