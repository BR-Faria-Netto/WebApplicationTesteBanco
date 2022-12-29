using RotasApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
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

app.MapMethods( ListaRotas.Parametro, ListaRotas.Metodo, ListaRotas.Func);

app.MapMethods( MelhorRota.Parametro, MelhorRota.Metodo, MelhorRota.Func);

app.MapControllers();

app.Run();
