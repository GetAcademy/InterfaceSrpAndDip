namespace InterfaceSrpAndDip
{
    internal class ConsoleLineFetcher : ILineFetcher
    {
        public string GetLine()
        {
            var line = Console.ReadLine();
            return line.Length == 0 ? null : line;
        }
    }
}
