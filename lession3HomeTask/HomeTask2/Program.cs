
int coordXpointA;
int coordYpointA;
int coordZpointA;
int coordXpointB;
int coordYpointB;
int coordZpointB;
double lenghAB;

//Считывает координаты точек A и B
void readDataOfPoint()
{
    Console.WriteLine("Введите координату x точки a");
    coordXpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату y точки a");
    coordYpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату z точки a");
    coordZpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату x точки b");
    coordXpointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату y точки b");
    coordYpointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату z точки b");
    coordZpointB = int.Parse(Console.ReadLine());

}

//Вычесляет растояние между точками
void colculateLenghAB(){
 lenghAB = Math.Sqrt(Math.Pow((coordXpointA - coordXpointB), 2) + Math.Pow((coordYpointA - coordYpointB), 2) + Math.Pow((coordZpointA - coordZpointB), 2));
}

readDataOfPoint();
colculateLenghAB();

Console.WriteLine(lenghAB);