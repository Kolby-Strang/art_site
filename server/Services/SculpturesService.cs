
namespace art_site.Services;

public class SculpturesService
{
    private readonly SculpturesRepository _repo;

    public SculpturesService(SculpturesRepository repo)
    {
        _repo = repo;
    }

    internal List<Sculpture> getSmallSculptures()
    {
        List<Sculpture> smallSculptures = _repo.getSmallSculptures();
        return smallSculptures;
    }
}