# ASP.NET Core MVC 1

**Автор:** sunmeat  
**Мова проєкту:** C#  
**Фреймворк:** ASP.NET Core MVC  

## Опис проєкту

Це базовий шаблон веб-додатку, створений за архітектурою **MVC (Model-View-Controller)** на основі **ASP.NET Core**.  
Проєкт підходить як стартова точка для навчання або швидкого прототипування веб-додатків на .NET.

Наразі репозиторій містить мінімальну конфігурацію «з коробки», яку створює Visual Studio при виборі шаблону **ASP.NET Core Web App (Model-View-Controller)**.

## Основні можливості
- Класична MVC-архітектура
- Razor-шаблони (.cshtml)
- Вбудована система Dependency Injection
- Підтримка Tag Helpers
- Статичні файли у папці `wwwroot`
- Конфігурація через `appsettings.json`
- Middleware-пайплайн ASP.NET Core

## Технології

- .NET 10
- C# 14
- Razor Views
- Entity Framework Core

## Структура проєкту
aspnetcoremvc1/
├── Controllers/          # Контролери
│   └── HomeController.cs
├── Models/               # Моделі та ViewModel'и
│   └── ErrorViewModel.cs
├── Views/                # Razor-вигляди
│   ├── Home/
│   │   └── Index.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _ValidationScriptsPartial.cshtml
│   └── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── wwwroot/              # Статичні файли (CSS, JS, зображення)
│   ├── css/
│   ├── js/
│   └── lib/
├── Properties/
│   └── launchSettings.json
├── appsettings.json
├── appsettings.Development.json
├── Program.cs            # Точка входу (починаючи з .NET 6)
├── aspnetcoremvc1.csproj
└── README.md             # ← цей файл

### Необхідне ПЗ
- .NET SDK (рекомендовано 8.0 або новіше) → https://dotnet.microsoft.com/download
- Visual Studio 2022/2025 або VS Code + C# Dev Kit

Удачі у розробці!
Якщо маєте питання – пишіть в Issues репозиторію або автору.
