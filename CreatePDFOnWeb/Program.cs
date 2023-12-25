using CreatePDFOnWeb.PDFHelper;
using DinkToPdf;
using DinkToPdf.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();




// register libwkhtmltox.dll 
var contentRootPath = builder.Environment.ContentRootPath;
var libwkhtmltoxPath = Path.Combine(contentRootPath, $"wwwroot\\pdfCreatorDll\\libwkhtmltox.dll");
var assemblyLoadContext = new CustomAssemblyLoadContext();
assemblyLoadContext.LoadUnmanagedLibrary(libwkhtmltoxPath);

// register service DinkToPdf
var converter = new SynchronizedConverter(new PdfTools());
builder.Services.AddSingleton<IConverter>(converter);




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
