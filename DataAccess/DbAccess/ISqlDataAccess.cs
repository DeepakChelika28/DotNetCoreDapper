
namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> GetData<T, U>(string storedProcedure, U parameters, string connectionId = "DbConnection");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "DbConnection");
    }
}