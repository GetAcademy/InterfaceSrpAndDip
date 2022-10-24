namespace InterfaceSrpAndDip
{
    internal class FileLineFetcher : ILineFetcher
    {
        private StreamReader _streamReader;

        public FileLineFetcher(string filename)
        {
            _streamReader = new StreamReader(filename);
        }

        public string GetLine()
        {
            var line = _streamReader.ReadLine();
            if (line == null) _streamReader.Close();
            return line;
        }
    }
}
