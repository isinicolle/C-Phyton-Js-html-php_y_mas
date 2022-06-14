//El tipo de triangulo
#include<stdio.h>
#include<windows.h>
main()
	{
		int l1, l2, l3;
		char*msj;
		
	printf("\n\tTipo de triangulo");
	printf("\n\t**** ** *********");
		
	printf("\n\nIngrese el primer lado: ");
	scanf("%d" ,&l1);
		
	printf("\n\nIngrese el segundo lado: ");
	scanf("%d" ,&l2);
		
	printf("\n\nIngrese el tercer lado: ");
	scanf("%d" ,&l3);
		
		if(l1==l2)
			if(l1==l3)
			msj="Equilatero";
		else 
			msj="Isoceles";
			else
				if(l2==l3)
				msj="Isoceles";
			else 
				msj="Escaleno";
				
	system("cls");
		
	printf("\n\tTipo de triangulo");
	printf("\n\t**** ** *********");
	
	printf("\n\nEl tipo de triangulo es: %s",msj);
		
		
		return 0;
	}

