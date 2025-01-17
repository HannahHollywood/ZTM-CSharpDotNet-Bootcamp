namespace ExtensionMethods.Extensions;

public static class PersonExtensions
{
    public static string ToAllPersonDetails(this Person person)
    {
        return $"{person.Name}, {person.Age}, {person.LuckyNumber}, {person.FavouriteColour}";
    }
}
