# estamos creando una solucion  para que los proyecto se referencien
dotnet new sln -n Biblioteca

# Representan los proyecto de nuestra solucion 
dotnet new classlib -n Biblioteca.Domain 
dotnet new classlib -n Biblioteca.Aplication
dotnet new classlib -n Biblioteca.Infrastructure
dotnet new webapi -n Biblioteca.Api

# agregar todos los proyectos a la soulion 
dotnet sln add Biblioteca.Domain Biblioteca.Aplication Biblioteca.Infraestructure Biblioteca.Api

# 
dotnet add Biblioteca.Infrastruture package Microsoft.EntityFrameworkCore.Design
