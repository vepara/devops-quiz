using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
var db = Environment.GetEnvironmentVariable("DB");
bool dbExists = true;
if (string.IsNullOrWhiteSpace(db))
{
    db = "[ERR! Need a DB in environment!]";
    dbExists = false;
    // db = "User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=logdb;Include Error Detail=true";
    // dbExists = true;
}

// app.UseHttpsRedirection();
// app.UseAuthorization();
app.MapControllers();
app.Map("/", () =>
{
    object? id = null;
    if (dbExists)
    {
        using NpgsqlConnection conn = new NpgsqlConnection(db);
        conn.Open();
        using var cmd = conn.CreateCommand();
        var msg = $"TechApp - Log inserted " + DateTime.Now.ToString();
        var sql = File.ReadAllText("init.sql").Replace("'{msg}'", $"'{msg}'");
        Console.WriteLine(sql);
        cmd.CommandText = sql;

        id = cmd.ExecuteNonQuery();
    }

    return $"TECH Application running. {Environment.NewLine} DB = {db} {Environment.NewLine} Inserted = {id}";
});
app.Run();