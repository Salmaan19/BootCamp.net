// See https://aka.ms/new-console-template for more information



using System.Data.SqlClient;



// Select query by using C#


//var connection = new SqlConnection(@"Data Source=;Initial Catalog=lindaa;Integrated Security=true");

//var commanad = new SqlCommand("select * from batch", connection);

//connection.Open();


//var reader = commanad.ExecuteReader();

//reader.Read();

//Console.WriteLine(reader.GetString(2));
//Console.WriteLine(reader.GetString(1)); 
//Console.WriteLine(reader.GetString(2));
//Console.WriteLine(reader.GetString(2));


//reader.Read();



// Inserty query by using C#

var inp1 = Console.ReadLine();
var inp2 = Console.ReadLine();


var connection = new SqlConnection(@"Data Source=;Initial Catalog=lindaa;Integrated Security=true");

var command = new SqlCommand(string.Format("insert into batch(batch, year) values('{0}','{1}');" ,inp1, inp2) , connection);


connection.Open();

command.ExecuteNonQuery();

connection.Close();

