//Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//14212->нет
//12821->да
//23432->да
int Pront(string message) 
{ 
    System.Console.Write(message); 
    int result = Convert.ToInt32(System.Console.ReadLine()); 
    return result; 
} 
System.Console.Write("Введите число: "); 
string? namber = Console.ReadLine(); 
int n = namber.Length;

int[] bufer = new int[n]; 
bool polindrom = true; 

for (int i = 0; i < n; i++)
{ 
    bufer[i] = namber[i]; 
} 
for(int i = 0; i < n; i++)
{ 
    if(bufer[i] != bufer[n-i-1]) 
    { 
        System.Console.Write("не является полиндромом"); 
        polindrom = false;
        break; 
    } 
} 
if (polindrom)
{ 
    System.Console.Write("является полиндромом"); 
}


