# GameVault

Aplicación web desarrollada con **ASP.NET Core MVC** (.NET 10) que permite gestionar un catálogo de videojuegos. El proyecto implementa las operaciones básicas de un CRUD (Crear, Leer, Editar y Eliminar) sobre una lista de videojuegos almacenada en memoria.

## Descripción

GameVault es un proyecto básico educativo en el que se modela un videojuego con los siguientes datos:

- **Id**: identificador único.
- **Título**: nombre del videojuego.
- **Género**: género del videojuego.
- **Plataforma**: plataformas en las que está disponible (PC, Switch, Xbox, PlayStation, etc.).
- **Precio**: precio en pesos chilenos (CLP).
- **Año de lanzamiento**: año de publicación del videojuego.

A través de la interfaz web es posible listar los videojuegos del catálogo, agregar nuevos, editar los existentes y eliminarlos.

## Tecnologías utilizadas

- .NET 10
- ASP.NET Core MVC
- Razor Views (`.cshtml`)
- Bootstrap (estilos en `wwwroot/lib/bootstrap`)
- jQuery y jQuery Validation

## Estructura del proyecto

```
GameVault/
├── Controllers/
│   ├── HomeController.cs
│   └── JuegoController.cs
├── Models/
│   ├── Videojuego.cs
│   └── ErrorViewModel.cs
├── Views/
│   ├── Home/
│   ├── Juego/
│   └── Shared/
├── wwwroot/
├── Program.cs
├── GameVault.csproj
└── appsettings.json
```

## Cómo ejecutar el proyecto

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/leorodriguez246/ASP.NET_Basico.git
   ```
2. Entrar a la carpeta del proyecto:
   ```bash
   cd ASP.NET_Basico
   ```
3. Ejecutar la aplicación:
   ```bash
   dotnet run
   ```
4. Abrir en el navegador la URL que indique la consola (por defecto `https://localhost:5001` o `http://localhost:5000`).

## Nota

Este proyecto básico fue desarrollado durante la clase de **Programación .NET con ASP.NET Core MVC**.
