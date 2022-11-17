namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string input = "12";

              int output = Convert.ToInt32(input);

              string MyFunction(string name)
              {
                  string output2 = "hello " + name;

                  return output2;
              }

              string output3 = MyFunction("Salman");//"hello salman"
              Console.WriteLine(output3);




              int Function(int a, int b)
              {
                  int c = a + b;

                  return c;
              }

              int d = Function(10, 15);
              Console.WriteLine(Function(10, 15));   */


            Calculator cal = new Calculator();
            int output = cal.Addition(15, 20);
            int output2 = cal.Addition("2" , "3");

            Console.WriteLine(output);

            Console.WriteLine(output2);

        }
    }
}