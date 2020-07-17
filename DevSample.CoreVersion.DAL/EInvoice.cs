using Dapper;
using NLog;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DevSample.CoreVersion.DAL
{
    public static class EInvoice
    {
        private static ILogger nLog = LogManager.GetCurrentClassLogger();
        public static void UpdateXMLExported(string ConnstringRW)
        {

            DynamicParameters parameters = new DynamicParameters();
            //parameters.Add("@InvoiceNumber", InvoiceNumber, DbType.String, ParameterDirection.Input);
            //parameters.Add("@Source", PrizeReciveType, DbType.String, ParameterDirection.Input);

            try
            {
                using (SqlConnection _conn = new SqlConnection(ConnstringRW))
                {
                    var results = _conn.Execute("proc_Turnkey_UpdateXMLExported", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                nLog.Error(ex, "proc_Turnkey_UpdateXMLExported Error");
            }
        }
    }
}
