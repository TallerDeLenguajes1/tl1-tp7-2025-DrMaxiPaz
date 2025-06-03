// See https://aka.ms/new-console-template for more information
using Personal;

Empleado empleado1 = new Empleado("Juan", "Perez", new DateTime(1990, 3, 1), EstadoCivil.Casado, Cargo.Investigador, new DateTime(2010, 6, 15), 3000);
Empleado empleado2 = new Empleado("Pedro", "Sanchez", new DateTime(1999, 12, 25), EstadoCivil.Soltero, Cargo.Ingeniero, new DateTime(2015, 6, 15), 3000);
Empleado empleado3 = new Empleado("Julieta", "Maria", new DateTime(2002, 6, 25), EstadoCivil.Soltero, Cargo.Investigador, new DateTime(2015, 6, 15), 3000); 

Empleado[] lista = new Empleado[3];
lista[0] = empleado1;
lista[1] = empleado2;
lista[2] = empleado3;
double montoTotal = 0;
foreach (var empleado in lista)
{
    Console.WriteLine($"\n\tNombre: {empleado.Nombre}, Apellido: {empleado.Apellido}, Fecha de Nacimiento: {empleado.FechaNacimiento.ToShortDateString()},Edad: {empleado.Edad()} años , Estado Civil: {empleado.Estado}");
    Console.WriteLine($"\t, Fecha de Ingreso: {empleado.FechaIngreso.ToShortDateString()}, Sueldo: {empleado.Sueldo}, Salario: {empleado.Salario()} Cargo: {empleado.Posicion} Antigüedad: {empleado.Antiguedad()} años, , Años para Jubilación: {empleado.Jubilacion()}");
    montoTotal += empleado.Salario();
}
Console.WriteLine($"\n\tEl monto total en salarios es de {montoTotal}");

if (lista[0].Jubilacion() < lista[1].Jubilacion() && lista[0].Jubilacion() < lista[2].Jubilacion())
{
    Console.WriteLine($"\n\tEl empleado más próximo a jubilarse es: {lista[0].Nombre} {lista[0].Apellido}, con {lista[0].Edad()} años, {lista[0].Antiguedad()} años de antigüedad y {lista[0].Jubilacion()} años para jubilarse.");
}
else if (lista[1].Jubilacion() < lista[0].Jubilacion() && lista[1].Jubilacion() < lista[2].Jubilacion())
{
    Console.WriteLine($"\n\tEl empleado más próximo a jubilarse es: {lista[1].Nombre} {lista[1].Apellido}, con {lista[1].Edad()} años, {lista[1].Antiguedad()} años de antigüedad y {lista[1].Jubilacion()} años para jubilarse.");
}
else
{
    Console.WriteLine($"\n\tEl empleado más próximo a jubilarse es: {lista[2].Nombre} {lista[2].Apellido}, con {lista[2].Edad()} años, {lista[2].Antiguedad()} años de antigüedad y {lista[2].Jubilacion()} años para jubilarse.");
}
