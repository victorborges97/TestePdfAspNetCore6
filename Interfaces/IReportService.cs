namespace TestePdf.Interfaces
{
    public interface IReportService
    {
        public byte[] GeneratePdfReport(String date, String nomeEmpresa, String dataInicio, String dataFim);
    }
}
