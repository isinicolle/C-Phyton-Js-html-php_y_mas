//Total a pagar de un cliente por llamadas telefonicas
#include<stdio.h>
#include<windows.h>
main()
{
	char*msj, nombre[20];
	int co;
	float tp, precio; //tp=total a pagar
	float min, subtotal;
	const float imp=0.15;

	printf("\n\tServicio de llamadas telefonicas");
	printf("\n\t******** ** ******** ***********");
	
	printf("\n\nIngrese el nombre del cliente: ");
	scanf("%s",&nombre);
			
	printf("\n\nCodigo Continente Precio por minuto");
	printf("\n1       America   L. 15.00");
	printf("\n2       Asia      L. 30.00");
	printf("\n3       Europa    L. 25.00");
	printf("\n4       Africa    L. 20.00");
	printf("\n5       Oceania   L. 35.00");
	
	printf("\n\n Ingrese el Codigo a donde desea llamar: ");
	scanf("%d",&co);
	
	system("pause");
	system("cls");
	
	switch(co){
	case 1: 
		msj="America";
	printf("\n\tServicio de llamadas telefonicas");
	printf("\n\t******** ** ******** ***********");
	
		printf("\n\n\tIngrese la cantidad de minutos hablados: ");
		scanf("%f",&min);
		precio=15.00;
		subtotal=(min*precio);
		tp=subtotal+(subtotal*imp); 
			printf("\n\n");
		system("pause");
		system("cls");
		
	printf("\n\tFactura");
	printf("\n\t*******");
	
	printf("\n\nNombre del cliente: %s",nombre);
	printf("\nContinente que llamo: %s",msj);
	printf("\nCantidad de minutos llamados: %.2f",min);
	printf("\nPrecio por minuto: %.2f",precio);
	printf("\nSubtotal: %.2f,",subtotal);
	printf("\nImpuesto sobre ventas: 15");
	printf("\nTotal a pagar: %.2f,",tp);
		break; 
	case 2:  
	printf("\n\tServicio de llamadas telefonicas");
	printf("\n\t******** ** ******** ***********");
	
		msj="Asia";
		printf("\n\n\tIngrese la cantidad de minutos hablados: ");
		scanf("%f",&min);
		precio=35.00;
		subtotal=min*precio;
		tp=subtotal+(subtotal*imp); 
			printf("\n\n");
		system("pause");
		system("cls");
		
	printf("\n\tFactura");
	printf("\n\t*******");
	
	printf("\n\nNombre del cliente: %s",nombre);
	printf("\nContinente que llamo: %s",msj);
	printf("\nCantidad de minutos llamados: %.2f",min);
	printf("\nPrecio por minuto: %.2f",precio);
	printf("\nSubtotal: %.2f,",subtotal);
	printf("\nImpuesto sobre ventas: 15");
	printf("\nTotal a pagar: %.2f,",tp);
		break; 
	case 3: 
	printf("\n\tServicio de llamadas telefonicas");
	printf("\n\t******** ** ******** ***********");
	
		msj="Europa";
		printf("\n\n\tIngrese la cantidad de minutos hablados: ");
		scanf("%f",&min);
		precio=25.00;
		subtotal=min*precio;
		tp=subtotal+(subtotal*imp);
			printf("\n\n");
		system("pause");
		system("cls");
		
	printf("\n\tFactura");
	printf("\n\t*******");
	
	printf("\n\nNombre del cliente: %s",nombre);
	printf("\nContinente que llamo: %s",msj);
	printf("\nCantidad de minutos llamados: %.2f",min);
	printf("\nPrecio por minuto: %.2f",precio);
	printf("\nSubtotal: %.2f,",subtotal);
	printf("\nImpuesto sobre ventas: 15");
	printf("\nTotal a pagar: %.2f,",tp);
		break; 
	case 4: 
	printf("\n\tServicio de llamadas telefonicas");
	printf("\n\t******** ** ******** ***********");
	
		msj="Africa";
		printf("\n\n\tIngrese la cantidad de minutos hablados: ");
		scanf("%f",&min);
		precio=20.00;
		subtotal=min*precio;
		tp=subtotal+(subtotal*imp);
			printf("\n\n");
		system("pause");
		system("cls");
		
	printf("\n\tFactura");
	printf("\n\t*******");
	
	printf("\n\nNombre del cliente: %s",nombre);
	printf("\nContinente que llamo: %s",msj);
	printf("\nCantidad de minutos llamados: %.2f",min);
	printf("\nPrecio por minuto: %.2f",precio);
	printf("\nSubtotal: %.2f,",subtotal);
	printf("\nImpuesto sobre ventas: 15");
	printf("\nTotal a pagar: %.2f,",tp);
		break; 
	case 5: 
	printf("\n\tServicio de llamadas telefonicas");
	printf("\n\t******** ** ******** ***********");
	
		msj="Oceania";
		printf("\n\n\tIngrese la cantidad de minutos hablados: ");
		scanf("%f",&min);
		precio=35.00;
		subtotal=min*precio;
		tp=subtotal+(subtotal*imp);
		printf("\n\n");
		system("pause");
		system("cls");
		
	printf("\n\tFactura");
	printf("\n\t*******");
	
	printf("\n\nNombre del cliente: %s",nombre);
	printf("\nContinente que llamo: %s",msj);
	printf("\nCantidad de minutos llamados: %.2f",min);
	printf("\nPrecio por minuto: %.2f",precio);
	printf("\nSubtotal: %.2f,",subtotal);
	printf("\nImpuesto sobre ventas: 15");
	printf("\nTotal a pagar: %.2f,",tp);
	break; 
	default:
	printf("\n\nIngrese un servicio valido");
	}
		

	
	
	return 0;
}
