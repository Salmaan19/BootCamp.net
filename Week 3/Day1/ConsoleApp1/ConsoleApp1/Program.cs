// See https://aka.ms/new-console-template for more information


/* Console.WriteLine("Hello, World!");



Console.WriteLine(a + b);

Console.WriteLine(a - b);

Console.WriteLine(a * b);

Console.WriteLine(a / b);

string str = "Have a good day.. !";

Console.WriteLine(str);

for(int i = 0; i<=10; i++)
{
   Console.WriteLine(i);
}


for (int j = 1; j <= 5; j++) { 

   for(int k=1; k <=j; k++)
   {
       Console.Write("*");
   }
   Console.WriteLine(" ");
}


int c = 25;
int d = 0;

try
{
   Console.WriteLine(c / d);
}


catch (Exception e)
{

   Console.WriteLine("Error accur"); 
}


*/


try
{

    Console.WriteLine("Enter First Value");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Second Value");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Operator");
    string c = Console.ReadLine();

  

        if (c == "+")
        {
            Console.WriteLine(a + b);
        }
        else if (c == "-")
        {

            Console.WriteLine(a - b);
        }
        else if (c == "*")
        {
            Console.WriteLine(a * b);
        }
        else if (c == "/")
        {
            Console.WriteLine(a / b);
        }
        else
        {
            throw new Exception();
        }
   

   


}
catch(Exception e)
{
    Console.WriteLine("Catch Error");
}





