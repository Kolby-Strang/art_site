




namespace art_site.Services;

public class ImagesService
{
    private readonly ImagesRepository _repo;

    public ImagesService(ImagesRepository repo)
    {
        _repo = repo;
    }

    internal Image CreateImage(Image imgData, string userId)
    {
        UtilsService.RestrictAdminOnly(userId);
        Image image = _repo.CreateImage(imgData);
        return image;
    }

    internal Image EditImage(int id, Image imgData, string userId)
    {
        UtilsService.RestrictAdminOnly(userId);
        Image imageToUpdate = GetImageById(id);

        imageToUpdate.ImageUrl = imgData.ImageUrl ?? imageToUpdate.ImageUrl;
        imageToUpdate.SculptureId = imgData.SculptureId ?? imageToUpdate.SculptureId;

        Image image = _repo.EditImage(imageToUpdate);
        return image;
    }

    private Image GetImageById(int id)
    {
        Image image = _repo.GetImageById(id);
        return image;
    }

    internal List<Image> GetImagesBySculptureId(int id)
    {
        List<Image> images = _repo.GetImagesBySculptureId(id);
        return images;
    }

    internal string DestroyImageById(int id, string userId)
    {
        UtilsService.RestrictAdminOnly(userId);
        GetImageById(id);
        _repo.DestroyImageById(id);
        return "Image Deleted";
    }
}