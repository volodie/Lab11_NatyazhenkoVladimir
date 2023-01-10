using static System.Runtime.InteropServices.JavaScript.JSType;
using generics;

internal class Program
{
    private static void Main(string[] args)
    {

        Pair<int, string> pair = new Pair<int, string>(23, "abc");
        pair.GetSumPairValues(x => Console.WriteLine(x));
       
        ComparablePair<int, int> obj1 = new ComparablePair<int, int>(45, 20);
        ComparablePair<int, int> obj2 = new ComparablePair<int, int>(30, 100);

        obj1.GetCompareResult(obj2, x => Console.WriteLine(x));

    }

}