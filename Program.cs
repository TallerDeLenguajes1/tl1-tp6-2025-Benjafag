// 1
int numero;
Console.WriteLine("Numero: ");

string cadena = Console.ReadLine();
bool convertido = int.TryParse(cadena, out numero);

Console.WriteLine((convertido && numero > 0) ? invertirNum(numero) : "Numero invalido");

int invertirNum(int a)
{
  int result = 0;
  while (a >= 10)
  {
    result += a % 10;
    result *= 10;
    a /= 10;
  }
  return result + a % 10;
}


// 2 