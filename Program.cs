/* for(int i = 0; i <= 100; i++ ){
    Console.WriteLine(i);
} */

/* for(int i = 0; i <= 200; i++){
    if(i % 2 == 0){
        Console.WriteLine(i);
    }
} */

/* for (int i = 201; i <= 499; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    } 
}*/

/* int[] estudiantes = {
    12,34,45,21,11,18,32,18,17,16,15,71,31,14,15,11,10,78,19,20
};
int acumulador = 0;

for(int i = 0; i < estudiantes.Length; i++){
    if(estudiantes[i] >= 18){
        acumulador++;
    }
}
Console.WriteLine("En total hay "+ acumulador + " estudiantes mayores de edad");
 */


/* int[] personas = {
    1,0,1,1,1,1,0,1,0,0,0,1,1,1,1,1,0,0,0,0,1,1,0
};

int acumuladorMujeres = 0, acumuladorHombres = 0;

for (int i = 0; i < personas.Length; i++){
    if (personas[i] == 0) {
        acumuladorMujeres++;
    }
    else{
        acumuladorHombres++;
    }
}

Console.WriteLine("Hay " + acumuladorMujeres + " mujeres");
Console.WriteLine("Hay " + acumuladorHombres + " hombres"); */

/* int[] personas = {
    10,25,23,34,55,76,12,54,31,21,18,19,10,20,28
};
int sumaEdades = 0;

for(int i = 0; i < personas.Length; i++){
    sumaEdades += personas[i];
}

Console.WriteLine("La edad promedio es: " + sumaEdades/15); */

/* int[] estaturas = {
    140,160,170,155,178,198,200,167,190,187,165,187,195,145,167,185,143,165
};

int sumaEstaturas = 0;

for(int i = 0; i < estaturas.Length; i++){
    sumaEstaturas += estaturas[i];
}

int promedio;

promedio = sumaEstaturas/18;

if(promedio < 140){
   Console.WriteLine("Estudiantes muy bajos");
}
else if(promedio >= 140 && promedio <=170){
    Console.WriteLine("Estuddiantes de estatura normal");
} else{
    Console.WriteLine("Estudiantes muy altos");
}
 */

/* for(int i = 0; i <= 99; i++){
    if(i % 3 == 0){
        Console.WriteLine(i);
    }
} */

/* int numero;
Console.WriteLine("Ingrese un número: ");
numero = int.Parse(Console.ReadLine());
for(int i = 0; i <= 10; i++){
    Console.WriteLine(numero + " x " + i + " = " + i*numero);  
} */

/* for(int i = 0; i <= 100; i++){
    if(i % 5 == 0){
        Console.WriteLine(i);
    }
} */

/* double[] notas = {
  1.0,2.5,4.5,5.0,7.8,9.9,6.7,2.3,4.5,1.8,9.8,7.6,4.4,5.0,3.2
};
double sumaNotas = 0;

for(int i = 0; i < notas.Length; i++){
   sumaNotas += notas[i];
};

double promedio = 0;

promedio = sumaNotas / 15;
if(promedio > 4.0){
    Console.WriteLine("Aprobó");
} else{
    Console.WriteLine("Reprobó");
}; */





