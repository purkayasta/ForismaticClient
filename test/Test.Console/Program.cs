// See https://aka.ms/new-console-template for more information
using Forismatic.Installer;

Console.WriteLine("Hello, World!");


var client = ForismaticInstaller.CreateClient();

var quote = await client.GetQuoteAsync(Forismatic.Models.LanguageEnum.English);

System.Console.WriteLine(quote.Quote);
System.Console.WriteLine(quote.Author);
System.Console.WriteLine(quote.Link);