// See https://aka.ms/new-console-template for more information
using HtmlAgilityPack;

Console.WriteLine("Teste de construção de HTML!");

var html =
        @"<body>
            <p id='name'></p>
            <table border='1'>
                <thead>
                    <tr>
                        <td>Coluna 1</td>
                        <td>Coluna 2</td>
                    </tr>
                </thead>
                <tbody id='idTbody'>
                </tbody>
            </table>
        </body>";

var htmlDoc = new HtmlDocument();
htmlDoc.LoadHtml(html);
htmlDoc.GetElementbyId("name").InnerHtml = "Teste";

var tbody = htmlDoc.GetElementbyId("idTbody");

for (int i = 1; i < 11; i++)
{
    HtmlNode tr = HtmlNode.CreateNode("<tr></tr>");
    
    HtmlNode td1 = HtmlNode.CreateNode("<td></td>");
    td1.InnerHtml = $"L{i}C1";
    
    HtmlNode td2 = HtmlNode.CreateNode("<td></td>");
    td2.InnerHtml = $"L{i}C2";

    tr.AppendChild(td1);
    tr.AppendChild(td2);
    tbody.AppendChild(tr);
}

Console.WriteLine(htmlDoc.DocumentNode.InnerHtml);