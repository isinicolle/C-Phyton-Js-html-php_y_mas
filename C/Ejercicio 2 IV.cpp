//Total a pagar a un empleado
#include<stdio.h>
#include<windows.h>
main()
{
	char nombre[20];
	float sueldob ,phe,precio, IHSS, dedu, sueldo;
	int horas_extras;
	int cat;
	float rap;
	
	printf("\n\tTotal a pagar a un empleado");
	printf("\n\t***** * ***** * ** ********");
	
	printf("\n\nIngres el nombre del empleado: ");
	scanf("%s",&nombre);
	
	printf("\n\nIngrese el sueldo del empleado: ");
	scanf("%f",&sueldob);
	
	printf("\n\nIngrese la cantidad de horas extra: ");
	scanf("%d",&horas_extras);
	
	system("pause");
	system("cls");
	
	if(horas_extras>0) {
	printf("\n\tTotal a pagar a un empleado");
	printf("\n\t***** * ***** * ** ********");
	
	printf("\n\nCategoría precio por hora extra");
	printf("\n  1         100.00");
 	printf("\n  2         150.00");
	printf("\n  3         200.00");
 	printf("\n  4         250.00");
 	
 	printf("\n\n\tIngrese la categoria que el empleado pertenece: ");
 	scanf("%d",&cat);
 	
 	switch (cat){
	 
	 	case 1:
		
	 		if(horas_extras<=20){
	 			precio=100.00;
	 			phe=horas_extras*precio;
				sueldob=sueldob+phe;
		} 
			else {
				horas_extras=20;
				precio=100.00;
	 			phe=horas_extras*precio;
				sueldob=sueldob+phe;
		}
	 		break; 
	 	case 2: 
		
	 		if(horas_extras<=20){
	 			precio=150.00;
	 			phe=horas_extras*precio;
				sueldob=sueldob+phe;
		} 
			else {
				horas_extras=20;
				precio=150.00;
	 			phe=horas_extras*precio;
				sueldob=sueldob+phe;
		}
	 		break; 
	 	case 3: 
		
	 		if(horas_extras<=20){
	 			precio=200.00;
	 			phe=horas_extras*precio;
				sueldob=sueldob+phe;
		} 
			else {
				horas_extras=20;
				precio=200.00;
	 			phe=horas_extras*precio;
				sueldob=sueldob+phe;
		}
	 		break; 
	 	case 4:
	 		if(horas_extras<=20){
	 			precio=250.00;
	 			phe=horas_extras*precio;
				sueldob=sueldob+phe;
		} 
			else {
				horas_extras=20;
				precio=250.00;
	 			phe=horas_extras*precio;
				sueldob=sueldob+phe;
		}
	 		break;
 		default: 
		 printf("\n\nLos empleados con categoria mayor a 4 no se les paga horas extras");
	} } else { 
	printf("\n\nEl empleado no posee horas extras");
	}
	if(sueldob>=.6,000){
	rap=(sueldob*0.015);
	IHSS=sueldob-240.00;
	dedu=rap+IHSS;}
	else{
	rap=sueldob*0.015;
	IHSS=sueldob*0.04;
	dedu=rap+IHSS;
	}
	sueldo=sueldob-dedu;
	system("pause");
	system("cls");
	
	printf("\n\tTotal a pagar a un empleado");
	printf("\n\t***** * ***** * ** ********");
	
	printf("\n\nNombre del empleado: %s",nombre);
	printf("\n\nSueldo bruto del empleado: %.2f",sueldob);
	printf("\n\nTotal de deducciones: %.2f",dedu);
	printf("\n\nPago de horas extras: %.2f",phe);
	printf("\n\nPago total: %.2f",sueldo);
	
	return 0;
}
