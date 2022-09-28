using WkHtmlToPdfDotNet.Contracts;
using TestePdf.Interfaces;
using WkHtmlToPdfDotNet;

namespace TestePdf.Services
{
    public class ReportService : IReportService
    {
        private readonly IConverter _converter;
        public ReportService(IConverter converter)
        {
            _converter = converter;
        }

        public byte[] GeneratePdfReport(String date, String nomeEmpresa, String dataInicio, String dataFim)
        {
            var html = $@"
<!DOCTYPE html>
<html lang=""en"">
    <head>
        <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    </head>
    <body>
        <p class='teste'>Relatório de Movimentações por Período</p>
        <p>Período de {dataInicio} até {dataFim}</p>
        <br />

        <table>
            <thead>
                <tr>
                    <th>TERM MOD DOC</th>
                    <th>Data</th>
                    <th>Descrição</th>
                    <th>Valor Bruto</th>
                    <th>Tarifa</th>
                    <th>Valor Líquido</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>

<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
<tr>
                    <td>TERM MOD DOC</td>
                    <td>Data</td>
                    <td>Descrição</td>
                    <td>Valor Bruto</td>
                    <td>Tarifa</td>
                    <td>Valor Líquido</td>
                </tr>
            </tbody>
        </table>
    </body>
</html>";


            HtmlToPdfDocument htmlToPdfDocument = new HtmlToPdfDocument()
            {
                GlobalSettings = new GlobalSettings()
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings { Top = 25, Bottom = 25 },
                },
                Objects = {
                    new ObjectSettings()
                    {
                        PagesCount = true,
                        HtmlContent = html,
                        HeaderSettings = new HeaderSettings() {
                            FontSize = 11,
                            FontName = "Ariel",
                            Center=$@"{nomeEmpresa}",
                        },
                        FooterSettings = new FooterSettings()
                        {
                            FontSize = 11,
                            FontName = "Ariel",
                            Left = "DamPay",
                            Right = $@"Data: {date} Página [page] de [toPage]",
                            Line = true,
                        },
                        WebSettings = new WebSettings() {
                            DefaultEncoding = "utf-8",
                            UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets",  "styles.css"),
                        },
                        
                    }
                },
            };

            return _converter.Convert(htmlToPdfDocument);
        }
    }
}

