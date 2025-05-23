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


// 2 y 3
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
      case 5: result = Math.Abs(primNumero); break;
      case 6: result = Math.Pow(primNumero, 2); break;
      case 7: result = Math.Sqrt(primNumero); break;
      case 8: result = Math.Sin(primNumero); break;
      case 9: result = Math.Cos(primNumero); break;
      case 10: result = Math.Truncate(primNumero); break;
      default: result = -9999; break;
    }
    Console.WriteLine("Resultado: " + result);
  }
  else
  {
    Console.WriteLine("Numero/s no valido/s");
  }
  Console.WriteLine("Desea realizar otra operacion: \n[1] Si\n[0] No");
  buff = Console.ReadLine();
  int.TryParse(buff, out seguir);
} while (seguir != 0);


// 4
Console.WriteLine("Ingrese un texto: ");
string cadena = Console.ReadLine();

// Obtener la longitud de la cadena y muestre por pantalla.
int longitud = cadena.Length;
Console.WriteLine($"Longitud: {longitud}");

// A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas.
Console.WriteLine("Ingrese otro texto: ");
string cadena2 = Console.ReadLine();
string concatenacion = cadena + cadena2;
Console.WriteLine($"Concatenacion: {concatenacion}");

// Extraer una subcadena de la cadena ingresada.
string subcadena = cadena.Substring(longitud / 2);
Console.WriteLine($"Subcadena: {subcadena}");

// Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla.
foreach (var caracter in cadena)
{
  Console.WriteLine(caracter);
}

// Buscar la ocurrencia de una palabra determinada en la cadena ingresada.
Console.WriteLine($"Palabra a buscar en {cadena}: ");
string buscada = Console.ReadLine();
int coincidencias = 0, indice = cadena.IndexOf(buscada);
while (indice != -1)
{
  coincidencias++;
  indice = cadena.IndexOf(buscada, indice + 1);
}
Console.WriteLine($"Se encontró \"{buscada}\" {coincidencias} veces en \"{cadena}\"");

// Convierta la cadena a mayúsculas y luego a minúsculas.
string mayusculas = cadena.ToUpper();
string minusculas = cadena.ToLower();
Console.WriteLine($"Cadena en mayusculas: {mayusculas} \nCadena en minusculas: {minusculas}");

// Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
string[] separado = cadena.Split();
foreach (var palabra in separado)
{
  Console.WriteLine(palabra);
}

// Ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. (582+2 => 584)
Console.WriteLine("Ingrese una ecuacion simple (a op b)");
string ecuacion = Console.ReadLine();
int indiceOp = indiceOperador(ecuacion);
if (indiceOp != -1)
{
  char operador = ecuacion[indiceOp];
  string[] nums = ecuacion.Split(operador);
  int a, b;
  bool convA, convB;
  convA = int.TryParse(nums[0], out a);
  convB = int.TryParse(nums[1], out b);
  if (convA && convB)
  {
    double resultado = 0;
    switch (operador)
    {
      case '+': resultado = a + b; break;
      case '-': resultado = a - b; break;
      case '/': resultado = a / b; break;
      case '*': resultado = a * b; break;

    }
    Console.WriteLine($"Resultado = {resultado}");
  }
  else
  {
    Console.WriteLine("Expresion no formulada correctamente");
  }
}

int indiceOperador(string cadena)
{
  string operadores = "+-/*";
  int resultado = -1;
  foreach (var operador in operadores)
  {
    resultado = cadena.IndexOf(operador);
    if (resultado != -1)
      break;
  }
  return resultado;
}
