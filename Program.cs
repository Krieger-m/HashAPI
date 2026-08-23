using HashAPI.Utils;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello!\nWelcome to my HashAPI-test\n\nEnter \n\t/hash/hex[number] for hex code\n\t/hash/b64/[number] for b64 code\n\nhave fun!");

// returns a hex-hash for a number given as a param
app.MapGet("/hash/hex", (int num) =>
{
    string hashed = HashUtils.HexHash(num);

    return new
    {
        // Number = num,
        Code = hashed
    };
});

// returns a hex-hash for a number using /hash/hex/number format
app.MapGet("/hash/hex/{num}", static (int num) =>
{
    string hashed = HashUtils.HexHash(num);

    return new
    {
        // Number = num,
        Code = hashed
    };
});

app.Run();
