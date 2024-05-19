/* int Numero1, Numero2;

Console.WriteLine("Ingrese el primer número: ");
Numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
Numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("El resultado es: " + (Numero1 + Numero2)); */

// 2. Programa que permita multipicar 3 numeros

/* int Numero1, Numero2, Numero3;
Console.WriteLine("Ingrese el primer número: ");
Numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
Numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer número: ");
Numero3 = int.Parse(Console.ReadLine());
Console.WriteLine("El resultado es: " + (Numero1 * Numero2 * Numero3)); */

// 3. Programa para caluclar la distancia recorrida en un movimiento rectilineo. 

/* int Velocidad, Tiempo;
Console.WriteLine("Ingrese la velocidad: ");
Velocidad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tiempo: ");
Tiempo = int.Parse(Console.ReadLine());
Console.WriteLine("La distancia recorrida es: " + (Velocidad * Tiempo)); */

// 4. Programa que permita calcular la edad de una persona conociendo su año de nacimiento y el año actual.

/* int AñoNacimiento, AñoActual;
Console.WriteLine("Ingrese el año de nacimiento: ");
AñoNacimiento = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el año actual: ");
AñoActual = int.Parse(Console.ReadLine());
Console.WriteLine("La edad de la persona es: " + (AñoNacimiento - AñoActual) * -1); */

// 5. Programa para calcular el 20% de un número.
/* 
int Numero;
Console.WriteLine("Ingrese el número: ");
Numero = int.Parse(Console.ReadLine());
Console.WriteLine("El 20% del número es: " + (Numero * 0.20)); */

// 6. Programa que permita calcular el 30%, el 60% y el 90% de un número.

/* int Numero;
Console.WriteLine("Ingrese el número: ");
Numero = int.Parse(Console.ReadLine());
Console.WriteLine("El 30% del número es: " + (Numero * 0.30));
Console.WriteLine("El 60% del número es: " + (Numero * 0.60));
Console.WriteLine("El 90% del número es: " + (Numero * 0.90)); */

// 7. Programa que permita calcular el área de un cuadrado.

/* int Lado;
Console.WriteLine("Ingrese el lado del cuadrado: ");
Lado = int.Parse(Console.ReadLine());
Console.WriteLine("El área del cuadrado es: " + (Lado * Lado)); */

// 8. Programa que permita ingresar 5 numeros y calcular el promedio.

/* int Numero1, Numero2, Numero3, Numero4, Numero5;
Console.WriteLine("Ingrese el primer número: ");
Numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
Numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer número: ");
Numero3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el cuarto número: ");
Numero4 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el quinto número: ");
Numero5 = int.Parse(Console.ReadLine());
Console.WriteLine("El promedio de los números es: " + (Numero1 + Numero2 + Numero3 + Numero4 + Numero5) / 5); */

// 9. Programa que permita saber el valor que se pagará por la compra de varios prodcutos con la misma referencia.

/* int Cantidad, Precio;
Console.WriteLine("Ingrese la cantidad de productos: ");
Cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto: ");
Precio = int.Parse(Console.ReadLine());
Console.WriteLine("El total a pagar es: " + (Cantidad * Precio));
 */

// 10.

/* double Salario, DescuentoPension, DescuentoSalud, SalarioNeto;

Console.WriteLine("Ingrese el salario: ");
Salario = int.Parse(Console.ReadLine());
DescuentoPension = Salario * 0.10;
DescuentoSalud = Salario * 0.15;
SalarioNeto = Salario - DescuentoPension - DescuentoSalud;
Console.WriteLine("El descuento de pensión es: " + SalarioNeto); */

// 11. Programa que permita determinar si una persona es mayor de edad o no en base a su año de nacimiento y el año actual.

/* int AñoNacimiento, AñoActual;
Console.WriteLine("Ingrese el año de nacimiento: ");
AñoNacimiento = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el año actual: ");
AñoActual = int.Parse(Console.ReadLine());
if ((AñoActual - AñoNacimiento) >= 18){
    Console.WriteLine("La persona es mayor de edad");
}
else{
    Console.WriteLine("La persona es menor de edad");
} */

//12. Programa que permita determinar si un numero es o no positivo.
/* int Numero;
Console.WriteLine("Ingrese el número: ");
Numero = int.Parse(Console.ReadLine());
if (Numero > 0){
    Console.WriteLine("El número es positivo");
}
else{
    Console.WriteLine("El número es negativo");
} */

// 13. Programa que permita ddeterminar cual entre 2 numeros es el mayor.

/* int Numero1, Numero2;
Console.WriteLine("Ingrese el primer número: ");
Numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
Numero2 = int.Parse(Console.ReadLine());
if (Numero1 > Numero2){
    Console.WriteLine("El número mayor es: " + Numero1);
}
else if (Numero1 == Numero2){
    Console.WriteLine("Los números son iguales");
}
else{
    Console.WriteLine("El número mayor es: " + Numero2);
} */

// 14. Programa que permita determinar si un estudiante es apto o no a tomar refrigerio teniendo como condicion que su grado sea sexto o menor con un array de texto que el usuario pueda seleccionar
/* 
 string[] Grados = {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto"};

Console.WriteLine("Seleccione el grado del estudiante: ");
for (int i = 0; i < Grados.Length; i++){
    Console.WriteLine((i + 1) + ". " + Grados[i]);
}
int Grado = int.Parse(Console.ReadLine());
if (Grado <= 6){
    Console.WriteLine("El estudiante es apto para tomar refrigerio");
}
else{
    Console.WriteLine("El estudiante no es apto para tomar refrigerio");
} 
 */

// 15. Programa para detemrinar la mitad de un numero es mayor o menor a 100

/* int Numero;

Console.WriteLine("Ingrese el número: ");
Numero = int.Parse(Console.ReadLine());
if (Numero / 2 > 100){
    Console.WriteLine("La mitad del número es mayor a 100");
}
else{
    Console.WriteLine("La mitad del número es menor a 100");
} */

// 16. Programa que reciba 2 numeros y si son iguales restarlos, pero si son diferentes, sumarlos.
/* int Numero1, Numero2;

Console.WriteLine("Ingrese el primer número: ");
Numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
Numero2 = int.Parse(Console.ReadLine());
if (Numero1 == Numero2){
    Console.WriteLine("La resta de los números es: " + (Numero1 - Numero2));
}
else{
    Console.WriteLine("La suma de los números es: " + (Numero1 + Numero2));
} */

// 17. 

/* string Nombre, Materia;
float CodigoEstudiante;
double Nota1, Nota2, Nota3, Promedio;

Console.WriteLine("Ingrese el nombre del estudiante: ");
Nombre = Console.ReadLine();
Console.WriteLine("Ingrese el código del estudiante: ");
CodigoEstudiante = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la materia: ");
Materia = Console.ReadLine();
Console.WriteLine("Ingrese la nota 1: ");
Nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 2: ");
Nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 3: ");
Nota3 = double.Parse(Console.ReadLine());
Promedio = (Nota1 + Nota2 + Nota3) / 3;

if (Promedio >= 3){
    Console.WriteLine("El estudiante " + Nombre + " código. " + CodigoEstudiante + " aprobó la materia " + Materia + " con un promedio de " + Promedio);
}
else{
    Console.WriteLine("El estudiante " + Nombre + " reprobó la materia " + Materia + " con un promedio de " + Promedio);
} */

// 18. Programa para determinar cuanto pagara un cliente por la compra de articulos en el cual se sabe el valor unitario y la cantidad con un descuento del 20% si el valor de la compra es mayor a 100.000

/* int ValorUnitario, Cantidad, ValorCompra, Descuento, ValorTotal;

Console.WriteLine("Ingrese el valor unitario del producto: ");
ValorUnitario = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de productos: ");
Cantidad = int.Parse(Console.ReadLine());
ValorCompra = ValorUnitario * Cantidad;
if (ValorCompra > 100000){
    Descuento = ValorCompra * 20 / 100;
    ValorTotal = ValorCompra - Descuento;
    Console.WriteLine("El valor total a pagar es: " + ValorTotal);
}
else{
    Console.WriteLine("El valor total a pagar es: " + ValorCompra);
}*/

// 19. Programa para determinar cuanto pagara un cliente por la compra de articulos en el cual se sabe el valor unitario y la cantidad con un descuento del 35% si el valor de la compra es mayor o igual a 20000 y un descuento del 15% si el valor de la compra es mayor a 20000

/* int ValorUnitario, Cantidad, ValorCompra, Descuento, ValorTotal;

Console.WriteLine("Ingrese el valor unitario del producto: ");
ValorUnitario = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de productos: ");
Cantidad = int.Parse(Console.ReadLine());
ValorCompra = ValorUnitario * Cantidad;
if (ValorCompra >= 20000){
    Descuento = ValorCompra * 35 / 100;
    ValorTotal = ValorCompra - Descuento;
    Console.WriteLine("El valor total a pagar es: " + ValorTotal);
}
else{
    Descuento = ValorCompra * 15 / 100;
    ValorTotal = ValorCompra - Descuento;
    Console.WriteLine("El valor total a pagar es: " + ValorTotal);
} */

// 20. Programa para determinar si un numero es par o impar usando operación Modulo

/* int Numero;

Console.WriteLine("Ingrese el número: ");
Numero = int.Parse(Console.ReadLine());
if (Numero % 2 == 0){
    Console.WriteLine("El número es par");
}
else{
    Console.WriteLine("El número es impar");
} */

// 21. Programa que permita ingresasr los valores de la temperatura de cada dia de la semana y luego calcular la temperatura promedio

/* int[] Temperaturas = new int[7];
int Suma = 0;
int Promedio;
for (int i = 0; i < Temperaturas.Length; i++){
    Console.WriteLine("Ingrese la temperatura del día " + (i + 1));
    Temperaturas[i] = int.Parse(Console.ReadLine());
    Suma += Temperaturas[i];
}

Promedio = Suma / 7;

Console.WriteLine("La temperatura promedio de la semana es: " + Promedio);
if (Promedio > 35){
    Console.WriteLine("Que semana tan calurosa.");
}
else if (Promedio < 35 && Promedio > 15){
    Console.WriteLine("Que clima tan delicioso.");
}
else{
    Console.WriteLine("Que semana tan fría.");
}
 */

// 22. Programa que permita definir a una super tienda el valor de descuento que se le hará a un cliente dependiendo del valor de la compra. Por compras entre 10000 y 20000 se hará un descuento del 10%, por compras entre 20001 y 50000 se hará un descuento del 20% y por compras mayores a 50000 se hará un descuento del 30%.

/* int ValorCompra, Descuento, ValorTotal;

Console.WriteLine("Ingrese el valor de la compra: ");
ValorCompra = int.Parse(Console.ReadLine());
if (ValorCompra >= 10000 && ValorCompra <= 20000){
    Descuento = ValorCompra * 10 / 100;
    ValorTotal = ValorCompra - Descuento;
    Console.WriteLine("El valor total a pagar es: " + ValorTotal);
}
else if (ValorCompra >= 20001 && ValorCompra <= 50000){
    Descuento = ValorCompra * 20 / 100;
    ValorTotal = ValorCompra - Descuento;
    Console.WriteLine("El valor total a pagar es: " + ValorTotal);
}
else if (ValorCompra > 50000){
    Descuento = ValorCompra * 30 / 100;
    ValorTotal = ValorCompra - Descuento;
    Console.WriteLine("El valor total a pagar es: " + ValorTotal);
}
else{
    Console.WriteLine("El valor total a pagar es: " + ValorCompra);
}
 */

// 23. Programa para determinar si un deportista es aceptado o no. Para ser aceptado debes: a. Tener 18 años o menos b. Pesar 80kg o menos c. Medir más de 1.80m

/* int Edad, Peso;
double Altura;

Console.WriteLine("Ingrese la edad del deportista: ");
Edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el peso del deportista: ");
Peso = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del deportista: ");
Altura = double.Parse(Console.ReadLine());

if (Edad <= 18 && Peso <= 80 && Altura > 1.80){
    Console.WriteLine("El deportista es aceptado");
}
else{
    Console.WriteLine("El deportista no es aceptado");
} */

// 24. Programa para determinar si una letra es o no vocal con switch case

/* char Letra;

Console.WriteLine("Ingrese una letra: ");
Letra = char.Parse((Console.ReadLine()));

switch (Letra){
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("La letra es vocal");
        break;
    default:
        Console.WriteLine("La letra no es vocal");
        break;
} */

// 25. Programa que permita calcular el movmimiento rectilineo uniforme con switch case

/* int Opcion;
double Velocidad, Tiempo, Distancia;
Console.WriteLine("Seleccione la opción que desea calcular: ");
Console.WriteLine("1. Calcular la velocidad");
Console.WriteLine("2. Calcular el tiempo");
Console.WriteLine("3. Calcular la distancia");
Opcion = int.Parse(Console.ReadLine());

switch (Opcion){
    case 1:
        Console.WriteLine("Ingrese el tiempo: ");
        Tiempo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la distancia: ");
        Distancia = double.Parse(Console.ReadLine());
        Velocidad = Distancia / Tiempo;
        Console.WriteLine("La velocidad es: " + Velocidad);
        break;
    case 2:
        Console.WriteLine("Ingrese la velocidad: ");
        Velocidad = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la distancia: ");
        Distancia = double.Parse(Console.ReadLine());
        Tiempo = Distancia / Velocidad;
        Console.WriteLine("El tiempo es: " + Tiempo);
        break;
    case 3:
        Console.WriteLine("Ingrese la velocidad: ");
        Velocidad = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tiempo: ");
        Tiempo = double.Parse(Console.ReadLine());
        Distancia = Velocidad * Tiempo;
        Console.WriteLine("La distancia es: " + Distancia);
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}
 */

// 26. Programa que permita ingresar un numero y dar opcion al usuario de si quiere determinar si es par o no o si es negativo o no con switch case

/* int Numero, Opcion;

Console.WriteLine("Ingrese el número: ");
Numero = int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione la opción que desea: ");
Console.WriteLine("1. Determinar si el número es par o no");
Console.WriteLine("2. Determinar si el número es negativo o no");
Opcion = int.Parse(Console.ReadLine());

switch (Opcion){
    case 1:
        if (Numero % 2 == 0){
            Console.WriteLine("El número es par");
        }
        else{
            Console.WriteLine("El número es impar");
        }
        break;
    case 2:
        if (Numero < 0){
            Console.WriteLine("El número es negativo");
        }
        else{
            Console.WriteLine("El número es positivo");
        }
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
} */

// 27. Programa que muestre un menu que tenga las siguientes opciones: 1. Pasa o no la materia? 2. Es mayor o menor de edad. En el caso 1 solicitar 3 notas y determinar si el promedio es mayor a 3.0. En el caso 2 solicitar el año de nacimiento y el año actual para determinar si es o no mayor de edad

int Opcion;

Console.WriteLine("Seleccione una opción:");
Console.WriteLine("1. Pasa o no la materia");
Console.WriteLine("2. Es mayor o menor de edad");
Opcion = int.Parse(Console.ReadLine());

switch (Opcion)
{
    case 1:
        double nota1, nota2, nota3, promedio;
        Console.WriteLine("Ingrese la primera nota: ");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda nota: ");
        nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la tercera nota: ");
        nota3 = double.Parse(Console.ReadLine());
        promedio = (nota1 + nota2 + nota3) / 3;
        if (promedio > 3.0)
        {
            Console.WriteLine("El estudiante pasa la materia con un promedio de " + promedio);
        }
        else
        {
            Console.WriteLine("El estudiante no pasa la materia con un promedio de " + promedio);
        }
        break;
    case 2:
        int añoNacimiento, añoActual, edad;
        Console.WriteLine("Ingrese el año de nacimiento: ");
        añoNacimiento = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el año actual: ");
        añoActual = int.Parse(Console.ReadLine());
        edad = (añoNacimiento - añoActual) * -1;
        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
        else
        {
            Console.WriteLine("Es menor de edad");
        }
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}

















