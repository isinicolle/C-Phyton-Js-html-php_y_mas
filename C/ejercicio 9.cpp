//Servicios de una compania de internet
#include<stdio.h>
#include<windows.h>
main()
	{
	char*msj;
	char*msj2;
	char*msj3;
	char*msj4; 
	char nomb[10];
	int servicio;
	char compania;
	
	
	printf("\n\tServicio de Internet");
	printf("\n\t******** ** ********");
	
	printf("\n\nIngrese el nombre del cliente: ");
	scanf("%s",&nomb);
	
	printf("\n\nIngrese su servicio de internet de la siguiente manera:\n\n Coloque A para Dial Up\n\n Coloque B Linea Dedicada: \n\n");
	printf("\n\nServicio: ");
	scanf("%s",&compania);
	
	printf("\n\n");
	system("pause");
	system("cls");
	
	if(compania=='A' || compania=='a') {
	msj="Servicio contratado: Dial Up";
	msj2="Precio: 150.00";
	msj3="Gracias por contratar este servicio";
	msj4="Total a pagar: 150.50"; }
	
	else 
	if (compania=='B' || compania=='b') {
		printf("\n\Ingrese su servicio de velocidad de internet en la empresa Linea Dedicada");
		printf("\n\n[ 1 ]...128 L. 300\n\n[ 2 ]...256 L. 500\n\n[ 3 ]...512 L. 700\n\n[ 4 ]...1024 L. 950");
		printf("\n\nServicio: ");
		scanf("\n\t%s",&servicio);
		
	
		printf("\n\n");
		system("pause");
		system("cls");
		
			switch (servicio){
		
			case '1':
			msj="Servicio contratado: Linea Dedicada\n\n Velocidad: 128";
			msj2="Precio: 300.00";
			msj3="Impuesto sobre la venta: 15";
			msj4="Total a pagar: 345.50"; 
			break;
			case '2': 
			msj="Servicio contratado: Linea Dedicada\n\nVelocidad: 256";
			msj2="Precio: 500.00";
			msj3="Impuesto sobre la venta: 15";
			msj4="Total a pagar: 575.50"; 
			break;
			case '3':
			msj="Servicio contratado: Linea Dedicada\n\nVelocidad: 512";
			msj2="Precio: 700.00";
			msj3="Impuesto sobre la venta: 15";
			msj4="Total a pagar: 805.50"; 
			break;
			case '4':
			msj="Servicio contratado: Linea Dedicada\n\nVelocidad: 1024";
			msj2="Precio:  950.00";
			msj3="Impuesto sobre la venta: 15";
			msj4="Total a pagar: 1092.50"; 
			break;
			default:
			printf("\n\nIngrese un servicio valido");
			
		}
	} 
	else 


						
	printf("\n\tTicket");
	printf("\n\nNombre del cliente: %s" ,nomb);
	printf("\n\n%s",msj);
	printf("\n\n%s",msj2);	
	printf("\n\n%s",msj3);	
	printf("\n\n%s",msj4);	

	
		return 0;
	}
