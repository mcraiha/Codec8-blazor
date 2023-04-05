
public static class Common
{
    public static string GetByteArrayAsSplittedHex(byte[] bytes)
    {
        return String.Join(" ", Array.ConvertAll(bytes, x => x.ToString("X2")));
    }
}