using Microsoft.EntityFrameworkCore;
using RedditBackend;
using RedditBackend.Services;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Services.BuildServiceProvider().GetService<IConfiguration>();

builder.Services.AddDbContext<ApplicationDbContext>(builder =>
    builder.UseSqlServer(config.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPostsService, PostsService>();

builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();
