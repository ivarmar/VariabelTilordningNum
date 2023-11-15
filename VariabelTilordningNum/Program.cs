using gouldavan;
namespace VariabelTilordningNum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                MyConsole mathInstance = new MyConsole();

                Console.WriteLine($"The total is: {mathInstance.MathNumbers()}");

                var Empty = MyConsole.Nothing();
                Console.WriteLine($"{Empty}");
            }


        }




    }
}