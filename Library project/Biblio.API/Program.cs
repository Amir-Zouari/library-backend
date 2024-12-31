using Biblio.Data.Contexts;
using Biblio.Data.Repositories;
using Biblio.Service.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BiblioContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
builder.Services.AddControllers();
builder.Services.AddScoped<BorrowService>();
builder.Services.AddScoped<BorrowRepository>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<CategoryRepository>();
builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<BookRepository>();

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

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

/*app.UseHttpsRedirection();*/

app.UseAuthorization();

app.MapControllers();

app.Run();
