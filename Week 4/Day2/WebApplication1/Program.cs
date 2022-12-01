using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

if(app.Environment.IsDevelopment())
{
   
    string sample1 = @"C:\Users\khalisal\Documents\BalanceSheet.csv";
    try
    {
        using (var stream = new StreamReader(sample1))
        {
            string line;

            while ((line = stream.ReadLine()) != null)
            {
                Console.WriteLine(line);
            } 
        }
    } catch(Exception e) {
        Console.WriteLine(e);
    }
}

if (app.Environment.IsProduction())
{

    string sample1 = @"C:\Users\khalisal\Documents\Enterprice.csv";
    try
    {
        using (var stream = new StreamReader(sample1))
        {
            string line;

            while ((line = stream.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
