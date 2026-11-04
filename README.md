# CalculatorApp — ЛР6: непрерывная интеграция и тестирование

[![.NET CI](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/actions/workflows/dotnet.yml/badge.svg)](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/actions/workflows/dotnet.yml)

Консольное приложение на C# (.NET 8) с классом `Calculator`, модульными тестами
на xUnit и автоматической сборкой и тестированием в GitHub Actions при каждом
push и Pull Request в `main`.

## Структура решения

```text
ci-cd-csharp-lab/
├── .github/workflows/dotnet.yml      # CI: restore → build → test
├── CalculatorApp.sln                 # решение Visual Studio
├── CalculatorApp/                    # консольное приложение
│   ├── Calculator.cs                 # Add, Subtract, Multiply, Divide
│   └── Program.cs
├── CalculatorApp.Tests/              # модульные тесты xUnit
│   └── CalculatorTests.cs
└── ОТЧЕТ.md                          # командный отчёт по ЛР6
```

## Как запустить

**Visual Studio:** открыть `CalculatorApp.sln`, затем **Тест → Запустить все тесты**
(обозреватель тестов покажет 22 успешных теста).

**Командная строка:**

```bash
dotnet build
dotnet test
dotnet run --project CalculatorApp
```

## Задачи и тесты

| Задача | Что сделано | Pull Request |
|--------|-------------|--------------|
| [#1](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/issues/1) | Проект, первый тест, CI | коммиты в `main` |
| [#2](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/issues/2) | Тест `Add` на наборе значений | [#6](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/pull/6) |
| [#3](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/issues/3) | Метод `Subtract` и тест | [#7](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/pull/7) |
| [#4](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/issues/4) | Метод `Multiply` и тест | [#8](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/pull/8) |
| [#5](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/issues/5) | Метод `Divide` и тесты, включая деление на ноль | [#9](https://github.com/vlasovrustam07-cpu/ci-cd-csharp-lab/pull/9) |

Подробности — в [ОТЧЕТ.md](ОТЧЕТ.md).
