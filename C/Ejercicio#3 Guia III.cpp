//Planilla de un empleado
#include<stdio.h>
#include<windows.h>

main()
	{
	char nombre[20];
	double SB, aumento, dedu , ihss , rap, totalpagar;  //SB=Sueldo bruto  dedu=deducciones
	const double i=0.04, r=0.015;
	
	printf("\n\tPlanilla de un empleado");
	printf("\n\t******** ** ** ********");
	
	printf("\n\nIngrese el nombre del empleado: ");
	scanf("%s",&nombre);
	
	printf("\n\nIngrese el sueldo: ");
	scanf("%lf", &SB); 
	
		//Aumento
		if(SB>=8000.00)
			aumento=SB+(SB*0.12);
		else
			aumento=SB+(SB*0.15);
			
			
	system("cls");
		//Deducciones
		
		if(SB>=6000)
			{
			ihss=(SB*.240);
			rap=(SB*r);
			dedu=(ihss+rap);}
		else
			{
			ihss=(SB*i);
			rap=(SB*r);
			dedu=(ihss+rap);}
			
			
		totalpagar=SB-dedu;
			
	
	printf("\n\tPlanilla de un empleado");
	printf("\n\t******** ** ** ********");
	
	printf("\n\nNombre del empleado: %s",nombre);
	printf("\n\nSueldo Bruto: %.2lf",SB);
	printf("\n\nSueldo con Aumento: %.2lf",aumento);
	printf("\n\nDeducciones: %.2lf", dedu);
	printf("\n\nTotal a pagar: %.2lf",totalpagar);
	
	
	
	
		return 0;
	}
