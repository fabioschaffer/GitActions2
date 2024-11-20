var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/product", () => {
    return new string[] { "Mouse 2" };

});
app.Run();