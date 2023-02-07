/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
*/

double InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToDouble(Console.ReadLine());
}

double[] GettingLineEquation() // получаем массив который состоит из коэф. уравнения прямой
{
    // y = coef[0] * x + coef[1];
    double[] coef = new double[2];
    coef[0] = InputInt("Введите коэф. k в уравнение прямой вида | y = k * x + b | ");
    coef[1] = InputInt("Введите коэф. b в уравнение прямой вида | y = k * x + b | ");
    return coef;
}

bool ExistenceOfIntersectionPoint(double [] coef1, double [] coef2) 
{
    if (coef1[0] == coef2[0]) return false; // можно было этот if засунуть в саму программу, а не как отдельную функцию
    else return true;                       // но на всякий случаю делаю так, чтобы приняли дз
}

double [] GettingIntersectionPointCoordinates(double [] coef1, double [] coef2) // double, так как происходит деление внутри этой функции
{
    double[] coordinates = new double[2]; // coordinates[0] = x, coordinates[1] = y | (x,y)
    double x = (coef2[1] - coef1[1]) / (coef1[0] - coef2[0]); // x = (b2 - b1) / (k1 - k2)
    coordinates[0] = x;
    coordinates[1] = coef1[0] * coordinates[0] + coef1[1]; // y = k1 * x + b1
    return coordinates;
}

void OutputCoordinates(double[] array)
{ 
    Console.WriteLine($"({array[0]} ; {array[1]})"); 
}

double[] FirstLine = GettingLineEquation();
Console.WriteLine($"Первая прямая y = {FirstLine[0]} * x + {FirstLine[1]}");
double[] SecondLine = GettingLineEquation();
Console.WriteLine($"Вторая прямая y = {SecondLine[0]} * x + {SecondLine[1]}");

if ( ExistenceOfIntersectionPoint(FirstLine, SecondLine) )
{
    OutputCoordinates(GettingIntersectionPointCoordinates(FirstLine, SecondLine));
}
else if ( FirstLine[1] == SecondLine[1]) // проверка что 1-ая и 2-ая линии не одинаковые
{
    Console.WriteLine("Линии одинаковые");
}
else
{
    Console.WriteLine("Точки пересечения не существует для этих прямых");
}
// если результат double, входные значения тоже лучше водить в double, программа неправильно работала из-за типа данных, так как
// при случаи y = 5x + 2; y = 9 * x + 4 - выводила (0 ; 2), когда ответ (-0.5; -0.5)