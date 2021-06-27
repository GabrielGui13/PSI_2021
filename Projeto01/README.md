# Forma de adicionar o Entity Framework no vscode

dotnet add package Microsoft.EntityFrameworkCore 
dotnet add package Microsoft.EntityFrameworkCore.tools 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet restore 


## Microsoft Documentation:
https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code

dotnet add package Microsoft.EntityFrameworkCore.SQLite -v 5.0.0-*,
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 5.0.0-*,
dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0-*,
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 5.0.0-*,
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 5.0.0-*,
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore -v 5.0.0-*


## Formas de criar elementos

dotnet tool install -g dotnet-aspnet-codegenerator

## To create a view 
### using Details template called TesteCategoria2 using model class (-m TesteCategoria2) at the dir(-outDir Views/Movies): 
dotnet-aspnet-codegenerator view TesteCategoria2 Details -m Categoria -outDir Views/Categoria