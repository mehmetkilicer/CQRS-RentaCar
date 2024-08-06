using CQRS_RentaCar.CQRS.Handlers.BodyStyleHandlers;
using CQRS_RentaCar.CQRS.Handlers.BrandHandlers;
using CQRS_RentaCar.CQRS.Handlers.RentalLocationHandler;
using CQRS_RentaCar.DAL;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<CarRentalContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<DeleteBrandCommandHandler>();


builder.Services.AddScoped<GetRentalLocationQueryHandler>();
builder.Services.AddScoped<GetRentalLocationByIdQueryHandler>();
builder.Services.AddScoped<CreateRentalLocationCommandHandler>();
builder.Services.AddScoped<UpdateRentalLocationCommandHandler>();
builder.Services.AddScoped<DeleteRentalLocationCommandHandler>();

builder.Services.AddScoped<GetBodyStyleQueryHandler>();
builder.Services.AddScoped<GetBodyStyleByIdQueryHandler>();
builder.Services.AddScoped<CreateBodyStyleCommandHandler>();
builder.Services.AddScoped<UpdateBodyStyleCommandHandler>();
builder.Services.AddScoped<DeleteBodyStyleCommandHandler>();

builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));


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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
