



namespace art_site.Services;

public class SculpturesService
{
    private readonly SculpturesRepository _repo;

    public SculpturesService(SculpturesRepository repo)
    {
        _repo = repo;
    }

    internal List<Sculpture> getSculptures()
    {
        List<Sculpture> sculptures = _repo.getSculptures();
        return sculptures;
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

    internal Sculpture EditSculpture(int id, Sculpture sculptureData, string userId)
    {
        UtilsService.RestrictAdminOnly(userId);
        Sculpture sculptureToUpdate = GetSculptureById(id);

        sculptureToUpdate.Year = sculptureData.Year ?? sculptureToUpdate.Year;
        sculptureToUpdate.IsLarge = sculptureData.IsLarge ?? sculptureToUpdate.IsLarge;
        sculptureToUpdate.Price = sculptureData.Price ?? sculptureToUpdate.Price;
        sculptureToUpdate.CoverImg = sculptureData.CoverImg ?? sculptureToUpdate.CoverImg;
        sculptureToUpdate.Description = sculptureData.Description ?? sculptureToUpdate.Description;
        sculptureToUpdate.Name = sculptureData.Name ?? sculptureToUpdate.Name;
        sculptureToUpdate.Dimensions = sculptureData.Dimensions ?? sculptureToUpdate.Dimensions;

        Sculpture sculpture = _repo.EditSculpture(sculptureToUpdate);
        return sculpture;
    }

    internal string DestroySculptureById(int id, string userId)
    {
        UtilsService.RestrictAdminOnly(userId);
        GetSculptureById(id);
        _repo.DestroySculptureById(id);
        return "Sculpture Destroyed";
    }
}