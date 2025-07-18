WebAppMvc
Este es un proyecto ASP.NET Core MVC que implementa un CRUD para gestionar roles y personas, conectado a una base de datos SQL Server (DESKTOP-C4JUHKE\SQLEXPRESS) usando autenticación de Windows. Incluye una relación entre Persona y Rol.
Requisitos

.NET 8.0 o superior
SQL Server Express (instancia DESKTOP-C4JUHKE\SQLEXPRESS)
Visual Studio o VS Code
Entity Framework Core CLI (dotnet-ef)

Instalación

Clona el repositorio:
git clone https://github.com/AlexSC224/WebAppMvc.git
cd WebAppMvc


Restaura los paquetes NuGet:
dotnet restore


Crea la base de datos WebAppMvcDb en SQL Server:

Conéctate a DESKTOP-C4JUHKE\SQLEXPRESS con SQL Server Management Studio (SSMS).
Crea una base de datos llamada WebAppMvcDb.
Asigna permisos db_datareader, db_datawriter, y db_ddladmin a tu usuario de Windows.


Aplica las migraciones:
dotnet ef database update


Inserta datos iniciales en las tablas Rol y Persona:
USE WebAppMvcDb;
INSERT INTO Rol (Nombre) VALUES
('Alejandro Salazar Cruz'),
('Administrador'),
('Usuario');
INSERT INTO Persona (Nombre, RolId) VALUES
('Juan Pérez', 1),
('María Gómez', 2),
('Carlos López', 3);


Ejecuta la aplicación:
dotnet run


Abre un navegador y ve a:

https://localhost:<Personas>/Roles para el CRUD de roles.
https://localhost:<Rols>/Personas para el CRUD de personas.



Estructura del proyecto

Controllers/RolesController.cs: Controlador MVC para el CRUD de roles.
Controllers/PersonasController.cs: Controlador MVC para el CRUD de personas.
Models/Rol.cs: Modelo de datos para la entidad Rol.
Models/Persona.cs: Modelo de datos para la entidad Persona.
Data/ApplicationDbContext.cs: Contexto de Entity Framework Core.
Views/Roles/: Vistas Razor para el CRUD de roles.
Views/Personas/: Vistas Razor para el CRUD de personas.

Configuración de la base de datos
La conexión a la base de datos está configurada en appsettings.json:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-C4JUHKE\\SQLEXPRESS;Database=WebAppMvcDb;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=True"
  }
}

Licencia
MIT License