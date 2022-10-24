namespace InterfaceSrpAndDip
{
    internal class CountService
    {
        public static int CountBlankLines(string filename)
        {
            using var sr = new StreamReader(filename);
            string line;
            var blankCount = 0;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Trim().Length == 0) blankCount++;
            }
            return blankCount;
        }
    }
}
