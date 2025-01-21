using DinkToPdf;
using DinkToPdf.Contracts;
using EBS.API;
using EBS.API.Extensions;
using EBS.API.ServicesPDF;
using EBS.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Generator PDF
builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter( new PdfTools() ) );
builder.Services.AddScoped<PdfGenerator>();

//PDF Invoice
builder.Services.AddSingleton<InvoiceFactory>();
builder.Services.AddSingleton<IncoiceRenderingService>();

// AND Generator PDF

// Add services to the container. EBS.API.Extensions
builder.Services.AddServiceExtensions();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

//builder.Services.AddDbContext<EBSContext>(options=>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
//});

//builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(
    x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.MapGet("invoice-report", async (InvoiceFactory invoiceFactory))=>{
//    Invoice invoice = invoiceFactory.Create();

//    var html = await RazorTemplateEngine.RenderAsync("Views/InvoiceReport.html")
//});
app.Run();
