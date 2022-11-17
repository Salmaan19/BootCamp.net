namespace ConsoleApp3
{
    internal class Program
    {

        // constructors

        /* class car
         {
             public string model;


             public car()
             {
                 model = "Mustang 1967";
             }
         }



         static void Main(string[] args)
         {

         car ford = new car();
             Console.WriteLine(ford.model);


         */


        // constructor parameters


        /*  class car
          {
            public string model;
            public string color;
            public  int year;


              public car(string ModelName, string ModelColor, int ModelYear)
              {
                  model = ModelName;
                  color = ModelColor;
                  year = ModelYear;
              }
          }

          static void Main(string[] args)
          {
              car ford = new car("Mustang", "red", 1967);
              Console.WriteLine(ford.color + " " + ford.year + " " + ford.model + " ");

          */


        // Access Modifiers



        /*  class car {

             private string model = "mustang";

         static void Main(string[] args)
         {
                 car ford = new car();
                 Console.WriteLine(ford.model);
         }
     }
 }
 }
        */



        /*  class car
           {

        private string model = "mustang";

         }

         static void Main(string[] args)
         {
         car ford = new car();
         Console.WriteLine(ford.model);

         */



        // encapsulation

        class person
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }

            }

            private int age;
            public int Age
            {
                get { return age; }
                set { age = value; }
            }


        }


            static void Main(string[] args)
            {
            person myObj = new person();
            myObj.Name = "Salmaan";
            myObj.Age = 28;

            Console.WriteLine(myObj.Name);
            Console.WriteLine(myObj.Age);



        }
        }
        
      }
           