//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//А(3,6,8);B(2,1,-7),->15,84
//A(7,-5,0);B(1,-1,9),->11,53

double Distance (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double result = Math.Sqrt(Math.Pow((xA - xB), 2)+ Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2));    
    return Math.Round(result, 2); 
}  
string[] str = {"X точки А","Y точки А","Z точки A","X точки B","Y точки B","Z точки B"}; 
double[] input = new double[6];  
for(int i = 0; i < input.Length; i++) {     Console.WriteLine($"Введите координату {str[i]}");     
input[i] = Convert.ToDouble(Console.ReadLine()); } 
double dist = Distance(input[0],input[1],input[2],input[3],input[4],input[5]); 
Console.WriteLine($"Растояние = {dist}");