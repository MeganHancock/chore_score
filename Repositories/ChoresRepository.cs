

namespace chore_score.Repositories;
public class ChoresRepository
{
    private readonly IDbConnection _db;
    private IDbConnection db;

    public ChoresRepository(IDbConnection _db)
    {
        _db = db;
    }

    internal Chore CreateChore(Chore choreData)
    {
        throw new NotImplementedException();
    }

    internal List<Chore> GetChores()
    {
        string sql = "SELECT * FROM chores;";
        List<Chore> chores = _db.Query<Chore>(sql).ToList();
        return chores;
    }
}