# ¿String es una tipo por valor o un tipo por referencia?

- String es uno de los tipos de referencia integrados de C#.

# ¿Qué secuencias de escape tiene el tipo string?

- En C#, las secuencias de escape comienzan con una barra invertida ('\') seguida de un caracter o codigo Unicode que representa el caracter especial deseado, como por ejemplo: '\n', '\t', '\0', etc.

# ¿Qué sucede cuando utiliza el caracter @ y $ antes de una cadena de texto?

- Agregar el caracter @ previo a un string nos lo pasará a texto plano, es decir ignorará las secuencias de escape que contenga, mientras que el $ nos permitirá insertar valores de variables de una manera sencilla en un string (interpolacion) para una mejor lectura del codigo.

# Expresiones Regulares

- Las expresiones regulares (también conocidas como regex) son patrones utilizados para buscar, coincidir o manipular texto. Se componen de una secuencia de caracteres que definen un conjunto de cadenas posibles. Son una herramienta muy poderosa para trabajar con cadenas, ya que permiten realizar búsquedas y validaciones complejas con muy pocas líneas de código.

## ¿Funcionan únicamente en C#?

- No, las expresiones regulares no son exclusivas de C#. Se utilizan en muchos lenguajes de programación. Lo que puede variar ligeramente entre lenguajes es la sintaxis o el motor de expresiones regulares que se utilice, pero en general los conceptos son los mismos.

## ¿En qué casos le parecen útiles? Enuncie al menos 3.

- Validar entradas del usuario
- Buscar patrones en textos
- Reemplazar texto automáticamente

## ¿Cómo se hace uso de estas en C#?

- En C#, se usan a través de la clase System.Text.RegularExpressions.Regex
