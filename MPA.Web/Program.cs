using Microsoft.EntityFrameworkCore;
using MPA.Data;

var builder = WebApplication.CreateBuilder(args);

// Start Services
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MPAContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapGet("/hello", () => "Hello World!");
});

app.Run();
