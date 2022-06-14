//La categoria del numero ingresado
#include<stdio.h>
main()
	{
	int n;
	
	
	printf("\n\tTipo de numero");
	printf("\n\t**** ** ******");
	
	printf("\n\nIngrese un numero: ");
	scanf("%d" ,&n);
	

	if (n=='0')
	printf("\n\nEl numero es neutro", n);
		if (n%2==0)
	printf("\n\n%d Es numero par.", n);
	else
	printf("\n\n%d Es un numero impar.", n);
	return 0;
	}
