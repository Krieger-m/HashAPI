using HashAPI.Utils;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello!\nWelcome to my HashAPI-test\n\nEnter \n\t/hash/hex[number] for hex code\n\t/hash/b64/[number] for b64 code\n\nhave fun!");

// --- HEX HASH ROUTES ---
app.MapGet("/hash/hex/{num}", static (int num) =>
{
    string hashed = HashUtils.HexHash(num);

    return new
    {
        Code = hashed
    };
});

// Optional query param version: /hash/hex?num=123
app.MapGet("/hash/hex", (int num) =>
{
    string hashed = HashUtils.HexHash(num);

    return new
    {
        Code = hashed
    };
});

// --- BASE64 HASH ROUTES ---
app.MapGet("/hash/b64/{num}", (int num) =>
{
    string hashed = HashUtils.Base64Hash(num);

    return new {
        Code = hashed
    };
});

// Optional query param version: /hash/b64?num=123
app.MapGet("/hash/b64", (int num) =>
{
    string hashed = HashUtils.HexHash(num);

    return new
    {
        Code = hashed
    };
});


app.Run();
