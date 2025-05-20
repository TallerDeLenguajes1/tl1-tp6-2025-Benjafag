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
float primNumero, segNumero;
float result;
bool convers1, convers2;
do
{
  do
  {
    Console.WriteLine("CALCULADORA\n[1]Sumar\n[2]Restar\n[3]Multiplicar\n[4]Dividir");
    buff = Console.ReadLine();
    int.TryParse(buff, out seleccion);
  } while (1 > seleccion || seleccion > 4);
  Console.WriteLine("Primer numero: ");
  buff = Console.ReadLine();
  convers1 = float.TryParse(buff, out primNumero);
  Console.WriteLine("Segundo numero: ");
  buff = Console.ReadLine();
  convers2 = float.TryParse(buff, out segNumero);
  if (convers1 && convers2)
  {
    switch (seleccion)
    {
      case 1: result = primNumero + segNumero; break;
      case 2: result = primNumero - segNumero; break;
      case 3: result = primNumero * segNumero; break;
      case 4: result = primNumero / segNumero; break;
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