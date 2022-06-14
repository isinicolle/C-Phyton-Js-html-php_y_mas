// programa que calcula y muestra el promedio de 3 notas de un estudiante
#include<stdio.h>
//***************************************************************************************
double promedio( int nota1, int nota2, int nota3) // Cuerpo de la función promedio
{
return (double)(nota1+nota2+nota3)/3;
}
//***************************************************************************************
void captura() // Cuerpo de la funcion captura
{
char nombre[30];
int n1,n2,n3;
double prom;
printf("\n\tPROMEDIO DE NOTAS");
printf("\n\t******** ** *****\n");
printf("Ingrese nombre: ");
scanf("%s",&nombre);
printf("\nIngrese nota 1: ");
scanf("%d",&n1);
printf("\nIngrese nota 2: ");
scanf("%d",&n2);
printf("\nIngrese nota 3: ");
scanf("%d",&n3);
prom = promedio(n1, n2, n3);
// Llamada la funcion promedio y el retorno de esa función se guarda en la variable prom
printf("\nEl promedio de [ %s ] es: [ %.2lf ]\n",nombre, prom);
}
//***************************************************************************************
main()
{
captura(); // Llama a la funcion captura
return 0;
}
