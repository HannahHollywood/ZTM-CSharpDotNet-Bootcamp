public static class IdentificationExtensions
{
    public static bool HasId(this IIdentification identification)
    {
        return identification.Id > 0;
    }
}
