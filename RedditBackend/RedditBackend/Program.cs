using Microsoft.EntityFrameworkCore;
using RedditBackend;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Services.BuildServiceProvider().GetService<IConfiguration>();

builder.Services.AddDbContext<ApplicationDbContext>(builder =>
    builder.UseSqlServer(config.GetConnectionString("DefaultConnection")));

builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();
