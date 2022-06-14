//El numero mayor
#include<stdio.h>
#include<windows.h>
main()
{
	int n1,n2,n3;

	printf("\n\tNumero Mayor");
	printf("\n\t****** *****");
	
	printf("\n\nIngrese el primer numero: ");
	scanf("%d", &n1);
	
	printf("\n\nIngrese el segundo numero: ");
	scanf("%d", &n2);
	
	printf("\n\nIngrese el tercer numero: ");
	scanf("%d", &n3);
	
	system("pause");
	system("cls");
	
	
	if(n1>n2 && n1>n3)
		printf("\n\nEl primer numero es el mayor: %d" ,n1);
	else 
		if(n2>n3 && n2>n1)
			printf("\n\nEl segundo numero es el mayor: %d", n2);
		else 
			if(n3>n2 && n3>n1)
				printf("\n\nEl tercer numero es el mayor: %d" ,n3);



	
	return 0;
}
