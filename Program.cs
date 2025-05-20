// 1
int numero;
Console.WriteLine("Numero: ");

string buff = Console.ReadLine();
bool convertido = int.TryParse(buff, out numero);

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
int seguir;
int seleccion;
double primNumero = -9999, segNumero = -9999;
double result;
bool convers1 = true, convers2 = true;
do
{
  do
  {
    Console.WriteLine("CALCULADORA\n[1]Sumar\n[2]Restar\n[3]Multiplicar\n[4]Dividir\n[5]Valor absoluto\n[6]Cuadrado\n[7]Raiz\n[8]Seno\n[9]Coseno\n[10]Parte entera");
    buff = Console.ReadLine();
    int.TryParse(buff, out seleccion);
  } while (1 > seleccion || seleccion > 10);
  Console.WriteLine(seleccion > 4 ? "Numero: " : "Primer numero: ");
  buff = Console.ReadLine();
  convers1 = double.TryParse(buff, out primNumero);
  if (seleccion <= 4)
  {
    Console.WriteLine("Segundo numero: ");
    buff = Console.ReadLine();
    convers2 = double.TryParse(buff, out segNumero);
  }
  if (convers1 && convers2)
  {
    switch (seleccion)
    {
      case 1: result = primNumero + segNumero; break;
      case 2: result = primNumero - segNumero; break;
      case 3: result = primNumero * segNumero; break;
      case 4: result = primNumero / segNumero; break;
      case 5: result = Math.Abs(primNumero);break;
      case 6: result = Math.Pow(primNumero, 2); break;
      case 7: result = Math.Sqrt(primNumero); break;
      case 8: result = Math.Sin(primNumero); break;
      case 9: result = Math.Cos(primNumero); break;
      case 10: result = Math.Truncate(primNumero); break;
      default: result = -9999; break;
    }
    Console.WriteLine( "Resultado: " + result );
  }
  else
  {
    Console.WriteLine("Numero/s no valido/s");
  }
  Console.WriteLine("Desea realizar otra operacion: \n[1] Si\n[0] No");
  buff = Console.ReadLine();
  int.TryParse(buff, out seguir);
} while (seguir != 0);