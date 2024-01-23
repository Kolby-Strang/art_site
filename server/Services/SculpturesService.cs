

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
        RestrictAdminOnly(userId);
        Sculpture sculpture = _repo.CreateSculpture(sculptureData);
        return sculpture;
    }
    private static void RestrictAdminOnly(string userId)
    {
        if (userId != "65330f5800fc89b954fa12ed")
        {
            throw new Exception("You are not allowed to post data!");
        }
    }
}