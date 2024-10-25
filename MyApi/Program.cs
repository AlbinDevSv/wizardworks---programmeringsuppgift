// Create a new instance of the WebApplication builder with the provided command-line arguments.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container for API documentation and exploration.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Build the WebApplication instance.
var app = builder.Build();

// Configure the HTTP request pipeline for development environment.
if (app.Environment.IsDevelopment())
{
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();
    // Enable middleware to serve Swagger UI, specifying the Swagger JSON endpoint.
    app.UseSwaggerUI();
}

// Map controller routes to the application.
app.MapControllers();

// Enable middleware to redirect HTTP requests to HTTPS.
app.UseHttpsRedirection();

// Run the application.
app.Run();
