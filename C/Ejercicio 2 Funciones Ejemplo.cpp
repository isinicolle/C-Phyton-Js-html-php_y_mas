// Programa que suma dos numeros por medio de una funci�n.
#include<stdio.h>
//***************************************************************************************
int sumar (int num1, int num2) //Cuerpo de la funcion sumar
{
int suma;
suma = num1 + num2;
return suma; //Retorna el resultado de la suma a la funci�n main guardando el resultado en resultado
}
//***************************************************************************************
main()
{
int n1,n2, resultado;
printf("\n\tSUMA DE DOS NUMEROS");
printf("\n\t**** ** *** *******\n");
printf("\nIngrese el valor del primer n%cmero: ",163);
scanf("%d",&n1);
printf("\nIngrese el valor del segundo n%cmero: ",163);
scanf("%d",&n2);
resultado = sumar(n1,n2); // Llamada de la funci�n
printf("\nLa suma es: [%d] \n",resultado);
return 0;
}
