using Commander.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// регистрируем сервисы
builder.Services.AddDbContext<CommanderContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CommanderConnection")));
builder.Services.AddControllers().AddNewtonsoftJson(s =>
{
    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICommanderRepo, SqlCommanderRepo>();

var app = builder.Build();

// настраиваем middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// подключаем контроллеры
app.MapControllers();

app.Run();
