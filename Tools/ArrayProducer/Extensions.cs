namespace ArrayProducer
{
    public static class Extensions
    {
        public static (int, int) ToIntInt(this string[] str) => (int.Parse(str[0]), int.Parse(str[1]));
    }
}