# AreaCalculeterLibariClass
Тестовое задание от Mindbox

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

Юнит-тесты
Легкость добавления других фигур
Вычисление площади фигуры без знания типа фигуры в compile-time
Проверку на то, является ли треугольник прямоугольным

Выбрал .Net Core Class Library, потому что кроссплатформенна, 3.1 - потому что LTS.

Выбрал xUnit для юнит тестов.

В ТЗ не указано, каким должно быть API, поэтому оставил и ООП, и обёртку статическими методами.

Результат
 Вычисляет площадь круга по радиусу
 Вычисляет площадь треугольника по трем сторонам
 Юнит тесты
 Лёгкость добавления фигур - не ясно. Нужен ли алгоритм для любых многоугольников? Сейчас все замкнутые фигуры реализуют IGeometrigShape
 Вычисление площади фигуры без знания типа фигуры в compile-time - если фигура реализует IGeometrigShape
 Проверка на то, является ли треугольник прямоугольным
