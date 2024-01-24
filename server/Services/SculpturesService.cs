

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
    internal List<Sculpture> getLargeSculptures()
    {
        List<Sculpture> largeSculptures = _repo.getLargeSculptures();
        return largeSculptures;
    }

    internal Sculpture CreateSculpture(Sculpture sculptureData, string userId)
    {
        UtilsService.RestrictAdminOnly(userId);
        Sculpture sculpture = _repo.CreateSculpture(sculptureData);
        return sculpture;
    }

    internal Sculpture GetSculptureById(int id)
    {
        Sculpture sculpture = _repo.GetSculptureById(id);
        return sculpture;
    }


}