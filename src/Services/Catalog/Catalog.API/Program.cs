var builder = WebApplication.CreateBuilder(args);

//Add services to the continer

var app = builder.Build();

//Configure the HTTP request pipeline.

app.Run();
