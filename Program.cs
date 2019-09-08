using System;

namespace CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = "teste".ToCharArray();
            char[] text1 = "teste1".ToCharArray();
            char[] text2= "test".ToCharArray();
            char[] text3 = "testw".ToCharArray();
            char[] text4 = "testwee".ToCharArray();
            System.Console.WriteLine(Compare.VerifySimilarity(text, text1));
            System.Console.WriteLine(Compare.VerifySimilarity(text, text2));
            System.Console.WriteLine(Compare.VerifySimilarity(text, text3));
            System.Console.WriteLine(Compare.VerifySimilarity(text, text4));
        }
    }
}
