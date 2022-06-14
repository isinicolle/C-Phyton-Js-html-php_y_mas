//Total a pagar a un empleado
#include<stdio.h>
#include<windows.h>

main()
	{
		char nomem[20]; //nomem=Nombre de empleado
		double totalpagar, numhrs, ph , sueldoB , dedu; //numhrs=numero de horas trabajadas , ph=pago por hora , sueldoB=Sueldo Bruto , dedu=Deducciones
		const double a=0.015; //Constante del porcentaje que le deducen por aportaciones privadas
		
		printf("\n\tCalcular total a pagar a un empleado");
		printf("\n\t******** ***** * ***** * ** ********");
		
		printf("\n\n*Ingrese el nombre del empleado: ");
		scanf("%s",&nomem);
		
		printf("\n\n*Ingrese el total de horas trabajadas por el empleado: ");
		scanf("%lf" ,&numhrs);
		
		printf("\n\n*Ingrese el pago por hora: ");
		scanf("%lf" ,&ph);
		
		sueldoB=numhrs*ph;
		totalpagar=sueldoB-(sueldoB*0.015);
		
		system("cls");
	
		
		printf("\n\tCalcular total a pagar a un empleado");
		printf("\n\t******** ***** * ***** * ** ********");
		
		printf("\n\n*Nombre del Empleado: %s",nomem);
		printf("\n\n*Total de Horas Trabajadas: %.1lf",numhrs);
		printf("\n\n*Sueldo Bruto del Empleado: %.2lf", sueldoB);
		printf("\n\n*Pago Total al empleado: %.2lf",totalpagar);
		
		
		
		
		return 0;
		
	}
