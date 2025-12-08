# ASP.NET Core MVC 1

**Оригінальний репозиторій:** https://github.com/sunmeat/aspnetcoremvc1  
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

- .NET 6 / .NET 7 / .NET 8 (залежно від версії, на якій створювався проєкт)
- C# 10+
- Razor Views
- Bootstrap (за замовчуванням у шаблоні)
- Entity Framework Core (можна додати)

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
text## Встановлення та запуск

### Необхідне ПЗ
- .NET SDK (рекомендовано 8.0 або новіше) → https://dotnet.microsoft.com/download
- Visual Studio 2022/2025 або VS Code + C# Dev Kit

### Кроки

```bash
# 1. Клонувати репозиторій
git clone https://github.com/sunmeat/aspnetcoremvc1.git
cd aspnetcoremvc1

# 2. Відновити пакети
dotnet restore

# 3. Запустити проєкт
dotnet run
Після запуску відкрийте у браузері адресу, яку покаже консоль
(зазвичай https://localhost:7xxx).
Як розвивати проєкт далі

Додати Entity Framework Core для роботи з базою даних
Підключити аутентифікацію (Identity або зовнішні провайдери)
Створити API-ендпоінти (додати контролери з [ApiController])
Підключити Swagger (Swashbuckle.AspNetCore)
Написати юніт-тести (xUnit / NUnit)

Розгортання

Azure App Service
IIS (Windows Server)
Linux + Nginx/Apache + Kestrel
Docker-контейнер

Приклад мінімального Dockerfile:
dockerfileFROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "aspnetcoremvc1.dll"]
Ліцензія
MIT License – можна вільно використовувати, змінювати та розповсюджувати.

Удачі у розробці!
Якщо маєте питання – пишіть в Issues репозиторію або автору.
