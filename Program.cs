var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () =>
{
    return Results.Json(new { Message="AlCode 8)"});
});

app.MapGet("/gatubela", () =>
{
    return Results.Json(new Message("Batman", "Gatubela", "Hoy te toca chiquita 3:)"));
});



app.Run();

internal record Message(string author,string to,string message );
