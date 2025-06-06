# ShapeAreaLibrary

Библиотека на C# для вычисления площади различных геометрических фигур.

## Назначение

Это учебное/тестовое задание демонстрирует:
- Расчёт площади фигур (круг, треугольник и т.д.)
- Валидируемую архитектуру (через интерфейсы и проверки)
- Легкость расширения: можно добавлять новые фигуры без изменения существующего кода
- Использование полиморфизма для вызова `.GetArea()` без знания типа фигуры на этапе компиляции
- Поддержку юнит-тестов (на базе xUnit)

## Реализованные фигуры

-  `Circle` — по радиусу
-  `Triangle` — по трём сторонам + определение прямоугольности
-  `Rectangle` — по двум сторонам (добавлен как демонстрация расширяемости)

##  Примеры использования

```csharp
var calculator = new AreaCalculator();

var circle = new Circle(2);
var triangle = new Triangle(3, 4, 5);
var rectangle = new Rectangle(4, 6);

Console.WriteLine(calculator.CalculateArea(circle));     // ~12.566
Console.WriteLine(calculator.CalculateArea(triangle));  // 6
Console.WriteLine(calculator.CalculateArea(rectangle)); // 24
