Console.WriteLine("## Conversão de tipos ##\n");


double varDouble = 12.456; // 8 bytes
int varInt = (int)varDouble; // 4 bytes (perda de precisão)

Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / (float)num2;
Console.WriteLine(resultado);

Console.ReadLine();