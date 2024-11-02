
using System;

class Program
{
    static void Main()
    {
        Console.Write("Yek adad vard konid: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"shoma adad ra vared kardid: {number}");
        }
        else
        {
            Console.WriteLine("Voroudi na motabar ast lotfan ye adad motabar vared konid.");
        }
    }
}
