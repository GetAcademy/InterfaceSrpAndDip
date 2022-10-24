using InterfaceSrpAndDip;

// Utgangspunktet
//var blankCount = CountService.CountBlankLines("sample.txt");
//Console.WriteLine(blankCount);

// Med SRP, uten interface
//var lines = File.ReadAllLines("sample.txt");
//var blankCount = CountServiceSrp.CountBlankLines(lines);
//Console.WriteLine(blankCount);

// Med DIP og interface - og SRP
//var lineFetcher = new FileLineFetcher("sample.txt");
var lineFetcher = new ConsoleLineFetcher();
var service = new CountServiceDip(lineFetcher);
var blankCount = service.CountBlankLines();
Console.WriteLine(blankCount);

// Dependency Inversion Principle
// Dependency Injection
// Constructor Injection