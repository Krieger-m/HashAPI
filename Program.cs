var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello!\nWelcome to my HashAPI-test\n\nEnter \n\t/hash/hex[number] for hex code\n\t/hash/b64/[number] for b64 code\n\nhave fun!");

app.Run();
