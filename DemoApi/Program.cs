var builder = WebApplication.CreateBuilder(args);

// Configuration for the "internals" for the application, which is mostly services and overriding the way stuff works.
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Everything after this point is "Middleware" - which is handling incoming requests and outgoing responses.
// We will create some middleware later.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// This looks at all of our controllers, reads the routing attributes, and creates a "lookup table" so that when requests come in, they can be sent to the right code to process that request.
app.MapControllers();

/*app.MapGet("/info", () =>
{
    return "All Good Here";
});*/

app.Run(); // Blocking call.
