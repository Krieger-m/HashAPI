using HashAPI.Utils;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello!\nWelcome to my HashAPI-test\n\nEnter \n\t/hash/hex/[input] for hex code\n\t/hash/b64/[input] for b64 code\n\nhave fun!");

// --- HEX HASH ROUTES ---
app.MapGet("/hash/hex/{input}", static (string input) =>
{
    string hashed = HashUtils.HexHash(input);

    return new
    {
        Code = hashed
    };
});

// Optional query param version: /hash/hex?input=123
app.MapGet("/hash/hex", (string input) =>
{
    string hashed = HashUtils.HexHash(input);

    return new
    {
        Code = hashed
    };
});

// --- BASE64 HASH ROUTES ---
app.MapGet("/hash/b64/{input}", (string input) =>
{
    string hashed = HashUtils.Base64Hash(input);

    return new {
        Code = hashed
    };
});

// Optional query param version: /hash/b64?input=123
app.MapGet("/hash/b64", (string input) =>
{
    string hashed = HashUtils.Base64Hash(input);

    return new
    {
        Code = hashed
    };
});


app.Run();
