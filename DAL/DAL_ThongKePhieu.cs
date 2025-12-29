using System.Data;

namespace DAL
{
    public class DAL_ThongKePhieu : Connect
    {
        public DAL_ThongKePhieu() { }
        public DataTable ThongKePhieuNhap(string type, string beginDate, string endDate)
        {
            string query = "EXEC usp_ThongKePhieu @Type , @BeginDate , @EndDate ";
            return ExecuteQuery(query, new object[] { type, beginDate, endDate });
        }
    }
}
