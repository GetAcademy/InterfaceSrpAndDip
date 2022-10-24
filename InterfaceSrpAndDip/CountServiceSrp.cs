namespace InterfaceSrpAndDip
{
    internal class CountServiceSrp
    {
        public static int CountBlankLines(string[] lines)
        {
            var blankCount = 0;
            foreach (var line in lines)
            {
                if (line.Trim().Length == 0) blankCount++;
            }
            return blankCount;
        }
    }
}
