using System.Text;

namespace CreatePDFOnWeb.PDFHelper
{
    public static class PdfReportGenerator
    {
        public static string GetHTMLString()
        {
            var members = Data.GetAllMembers();
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>Mitglieder-Liste</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Name</th>
                                        <th>Vorname</th>
                                        <th>Strasse</th>
                                        <th>PLZ</th>
                                        <th>Ort</th>
                                    </tr>");

            foreach (var member in members)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                  </tr>", 
                                  member.Firstname, member.LastName, member.Street, 
                                  member.PLZ, member.City);
            }

            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}
