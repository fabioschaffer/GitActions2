var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/product", () => {
    return new string[] { "Mouse", "Teclado" };

});
app.Run();