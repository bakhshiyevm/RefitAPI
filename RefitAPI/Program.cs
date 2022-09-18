// See https://aka.ms/new-console-template for more information
using Refit;
using RefitAPI;

Console.WriteLine("Hello, World!");


var usersClient = RestService.For<CatAPI>("https://catfact.ninja");
var users = await usersClient.GetFacts();
;