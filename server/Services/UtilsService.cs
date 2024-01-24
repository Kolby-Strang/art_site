namespace art_site.Services;

public class UtilsService
{
    public static void RestrictAdminOnly(string userId)
    {
        if (userId != "65330f5800fc89b954fa12ed")
        {
            throw new Exception("You are not allowed to post data!");
        }
    }
}