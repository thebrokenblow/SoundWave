using Microsoft.EntityFrameworkCore;
using Model.SoundWave.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
string connection = builder.Configuration.GetConnectionString("SoundWaveDBConnectionString");
builder.Services.AddDbContext<SoundWaveDBContext>(options => options.UseSqlServer(connection));
var app = builder.Build();
app.MapRazorPages();
app.Run();
