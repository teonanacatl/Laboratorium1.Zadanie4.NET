namespace Laboratorium1.Zadanie4.NET
{
    class Program
    {
        static void Main()
        {
            string path = @"data\test.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    char[] charArray = line.ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine(new string(charArray));
                }
            }
        }
    }
}
