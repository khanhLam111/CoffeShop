using coffeeshop.Data;
using coffeeshop.Models.Services;
using coffeeshop.Models.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- TẤT CẢ SERVICES PHẢI ĐẶT Ở ĐÂY (TRƯỚC var app = builder.Build()) ---

builder.Services.AddControllersWithViews();

// 1. Đăng ký DbContext (Chỉ dùng 1 dòng này, đúng tên "DefaultConnection")
builder.Services.AddDbContext<CoffeeshopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Đăng ký Repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// -----------------------------------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();