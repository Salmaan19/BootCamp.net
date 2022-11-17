namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("0 for ADD");
            Console.WriteLine("1 for SUBRTRACT");
            Console.WriteLine("2 for MULTIPLY");
            Console.WriteLine("3 for DIVIDE");


            Console.WriteLine("\n Enter Number");


            int inp = int.Parse(Console.ReadLine());

            var selection = (ConstantInProgram)inp;

            Console.WriteLine(selection);


            switch(selection)
            {

                case ConstantInProgram.addition:
                    break;

                case ConstantInProgram.subtration:
                    break;
                case ConstantInProgram.multiplication:
                    break;
                case ConstantInProgram.divide:
                    break;

                default:
                    break;
            }



        }
    }
}