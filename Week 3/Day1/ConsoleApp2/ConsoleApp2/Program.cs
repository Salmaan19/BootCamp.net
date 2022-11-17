// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string input = "12";

int output = Convert.ToInt32(input);

string MyFunction(string name)
{
    string output2 = "hello " + name;

    return output2;
}

string output3 = MyFunction("Salman");//"hello salman"
Console.WriteLine(output3);



int a;
int b;


int Function(int num)
{
    int c = a + b;

    return c;
}

int d = Function(a + b);
Console.WriteLine(d);