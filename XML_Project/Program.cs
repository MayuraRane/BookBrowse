using Newtonsoft.Json;
using XML_Project;
using XML_Project.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/BookBrowse/v1", async (string? BookName) =>
{
    SearchResultModel index = new SearchResultModel();
    string response = "";

    ApiResponse apiResponse = await index.GetApiResponseAsync(BookName);
    response = JsonConvert.SerializeObject(apiResponse, Formatting.Indented, new JsonSerializerSettings
    {
        NullValueHandling = NullValueHandling.Ignore,
        DefaultValueHandling = DefaultValueHandling.Ignore
    });

    return response;

})
.WithName("BookBrowse");

app.Run();
