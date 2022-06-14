// Programa que calcula el area de un triangulo por medio de una función.
#include<stdio.h>
//***************************************************************************************
double area_tria (double base, double altura) //Cuerpo de la funcion area
{
double area;
area = (base * altura)/2;
return area; //Retorna el resultado del qrea a la función main y la imprime
}
//***************************************************************************************
main()
{
double b, a;
printf("\n\tAREA DE UN TRIANGULO");
printf("\n\t**** ** ** *********\n");
printf("\nIngrese el valor de la base: ");
scanf("%lf",&b);
printf("\nIngrese el valor de la altura: ");
scanf("%lf",&a);
printf("\nEl area del triangulo es: [%.2lf] \n",area_tria(b, a));
//Llamada a la función dentro de la función printf
return 0;
}
