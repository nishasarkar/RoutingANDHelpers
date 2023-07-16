using NuGet.Frameworks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSession();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller}/{action}/{id?}"
   );

//employee/index/1/2
//product/index/1/2
app.MapControllerRoute(
    name: "default1",
    pattern: "{controller}/{action}/{id}/{catid}");//https://localhost:44367/product/index?id=1&catid=2 this is query string we can acess produc controller

//useless
//app.MapControllerRoute(
//    name: "default2",
//    pattern: "{controller}/{action}/{id}/{deptid}");

//
//product/index/1?catid=2
//product/index?id=1&catid=2
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");//https://localhost:44367/product/index/id=1 this the one 
//one way we can acess the product controller index action in a conventional way//default root

app.Run();
