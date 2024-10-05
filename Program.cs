var builder = WebApplication.CreateBuilder(args);
var CustomOrigins = "AllowedOrigins";

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure CORS to allow multiple origins
builder.Services.AddCors(options =>
{
    options.AddPolicy(CustomOrigins,
    builder =>
    {
        builder.WithOrigins("https://excelsior2.test", "https://excelsior.bitbyte.dk")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

builder.Services.AddMemoryCache((options) =>
{
    options.SizeLimit = 100;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors(CustomOrigins);
app.Run();
