/*Esta seccion es lo inicial del curso hasta el video 17. Son las operaciones basicas y algoritmos con numeros
 * using algoritmos;

multiplicar mult = new multiplicar();
Console.WriteLine(mult.multiply(2, 3));
Console.WriteLine(mult.multiply(5, 2));

dividir div = new dividir();
Console.WriteLine("Resultado: " + div.divide(10, 3));
Console.WriteLine(div.divide(40, 2));

potencia power = new potencia();
Console.WriteLine(power.power(5, 2));
Console.WriteLine(power.power(5, 3));

factorial fact = new factorial();
Console.WriteLine("Factorial: " + fact.factorial2(6));

numeroReal realnumber = new numeroReal();
Console.WriteLine("6 es un numero perfecto: " + realnumber.realnumber(6));
Console.WriteLine("7 es un numero perfecto: " + realnumber.realnumber(7));
Console.WriteLine("28 es un numero perfecto: " + realnumber.realnumber(28));
Console.WriteLine("28 es un numero perfecto: " + realnumber.realnumber(220));

numerosAmigos numerosAmigos = new numerosAmigos();
Console.WriteLine("220 y 284 son numeros amigos: " + numerosAmigos.amigo(220, 284));
Console.WriteLine("1184 y 1210 son numeros amigos: " + numerosAmigos.amigo(1184, 1210));
Console.WriteLine("1184 y 1211 son numeros amigos: " + numerosAmigos.amigo(1184, 1211));
Console.WriteLine("118 y 121 son numeros amigos: " + numerosAmigos.amigo(118, 121));

numeroCool numeroCool = new numeroCool();
Console.WriteLine("10 es un numero cool: " + numeroCool.cool(10));
Console.WriteLine("15 es un numero cool: " + numeroCool.cool(15));
Console.WriteLine("7 es un numero cool: " + numeroCool.cool(7));
Console.WriteLine("8 es un numero cool: " + numeroCool.cool(8));
*/

//Empieza seccion de arrays
using algoritmos;
arrays arreglo = new arrays();
arreglo.nombre();
palindromo palindromo = new palindromo();
Console.WriteLine("somosodgdfgfdunosomos es un palindromo: " + palindromo.palin("somosodgdfgfdunosomos"));
Console.WriteLine("somosonosomos es un palindromo: " + palindromo.palin("somosonosomos"));
calcularMinMaxAVG calcularMinMaxAVG = new calcularMinMaxAVG();
calcularMinMaxAVG.minMaxAVG([2.5, 2.3, 7.1, 7.5, 6.8]);
calcularMinMaxAVG.minMaxAVG([10.2, 2.3, 3.9, 1.2, 6.8]);
Burbuja burbuja = new Burbuja();
//burbuja.algBurbuja([2, 1, 5, 0, 4, 3, 7, 8, -1, 2, 4]);

//burbuja.algBurbuja([7, 29, 86, -20]);

//Seleccion seleccion = new Seleccion();
//seleccion.algSeleccion([2, 1, 5, 0, 4, 3, 7, 8, -1, 2, 4]);

Insercion insercion = new Insercion();
insercion.algInsercion([2, 1, 5, 0, 4, 3, 7, 8, -1, 2, 4]);


