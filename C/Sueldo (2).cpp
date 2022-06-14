//Programa que calcula el sueldo neto de un empleado 
#include<stdio.h>
#include<windows.h>
	main()
	{
		char nombre[30],genero;
		double sueldo, rap, sueldoNeto;
		printf("\n\tCalculo de sueldo neto");
		printf("\n\t******* ** ****** ****");
		
		printf("\n\nIngrese el nombre del empleado: ");
		scanf("%s",&nombre);
		
		printf("\n\nIngrese el sueldo: ");
		scanf("%lf",&sueldo);
		
		/*printf("\n\nIngres el genero: ");
		scanf("%s", &genero);*/  
		
		rap=sueldo*0.015;
		sueldoNeto=sueldo-rap;
		
		system("cls");
		
		printf("\n\tCalculo de sueldo neto");
		printf("\n\t******* ** ****** ****");
		
		printf("\n\nEmpleado %s", nombre);
		printf("\n\nSueldo: %.2lf", sueldo);
			printf("\n\nGenero %c", genero);
		printf("\n\nSueldo Neto: %.2lf", sueldoNeto);
		
		
		
		
		return 0;
	}
