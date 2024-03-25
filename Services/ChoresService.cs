
namespace chore_score.Services;
public class ChoresService
{

    private readonly ChoresRepository _repository;

    public ChoresService(ChoresRepository repository)
    {
        _repository = repository;
    }

    public List<Chore> GetChores()
    {
        List<Chore> chores = _repository.GetChores();
        return chores;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repository.CreateChore(choreData);
        return chore;
    }
}