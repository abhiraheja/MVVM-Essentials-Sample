namespace MVVM_Essentials_Lib
{
    public static class ShortName
    {
        public static string ToShort(this string Name, int Length)
        {
            if (Name.Length > Length)
            {
                string val = Name.Substring(0, (Length - 3));
                return val + "...";
            }
            return Name;
        }
    }
}
