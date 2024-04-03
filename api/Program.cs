var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();														

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())											// app is going to control the HTTP request pipeline
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();																		// When this is run, the actual server is being run. This is the point of origin of the app.
