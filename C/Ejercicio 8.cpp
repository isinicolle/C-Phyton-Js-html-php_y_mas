//El dia de la semana segun el numero ingresado
#include<stdio.h>
#include<windows.h>
main()
	{
	int n;
	char*msj;
	
	printf("\n\tDia de la semana");
	printf("\n\t*** ** ** ******");
	
	printf("\n\nIngrese un numero: ");
	scanf("%d",&n);
	
	if(n==1)
	 	msj="Domingo";
	else 
		if(n==2)
			msj="Lunes";
		else
			if(n==3)
				msj="Martes";
			else
					if(n==4)
	 					msj="Miercoles";
					else 
						if(n==5)
							msj="Jueves";
						else
							if(n==6)
								msj="Viernes";
							else
								if(n==7)
									msj="Sabado";
								else
						
	system("pause");
	system("cls");
		
	printf("\n\tDia de la semana");
	printf("\n\t*** ** ** ******");
	
	printf("\n\nEl dia es: %s",msj);
		return 0;
	}
