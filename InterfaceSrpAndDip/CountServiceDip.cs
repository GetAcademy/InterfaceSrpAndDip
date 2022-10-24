namespace InterfaceSrpAndDip
{
    internal class CountServiceDip
    {
        private ILineFetcher _lineFetcher;

        public CountServiceDip(ILineFetcher lineFetcher)
        {
            _lineFetcher = lineFetcher;
        }

        public int CountBlankLines()
        {
            string line;
            var blankCount = 0;
            while ((line = _lineFetcher.GetLine()) != null)
            {
                if (line.Trim().Length == 0) blankCount++;
            }
            return blankCount;
        }
    }
}
