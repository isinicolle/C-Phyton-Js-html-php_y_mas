//Total a pagar en caja
#include<stdio.h>
#include<windows.h>
 main()
 
 	{
 		int articulos; //Articulos , porque solo pide un tipo de articulo
 		double totalpagar, precio ,subtotal;
 		const float imp=0.15;
 		char nomclien[25], nomar[20]; //nomclien=Nombre del cliente , nomar=nombre del articulo
 		
 		printf("\n\tCalcular el Total a pagar");
 		printf("\n\t******** ** ***** * *****");
 		
		printf("\n\nIngrese el nombre del cliente: ");
 		scanf("%s" ,&nomclien);
 		
 		printf("\n\nIngrese el nombre del articulo: ");
 		scanf("%s" ,&nomar);
 		
 		printf("\n\nIngrese el precio del articulo: ");
 		scanf("%lf" ,&precio);
 		
 		printf("\n\nIngrese la cantidad de articulos que lleva: ");
 		scanf("%d",&articulos);
 		
 		subtotal=articulos*precio;
 		totalpagar=subtotal+(subtotal*imp);
 		
 		printf("\n\n");
 		
 		system("pause");
 		system("cls");
 		
 		printf("\n\tFactura");
 		printf("\n\t*******");
 		
 		printf("\n\nNombre Del Cliente: %s",nomclien);
 		printf("\n\nNombre Del Articulo Comprado: %s",nomar);
 		
 		printf("\n\nCantidad de Articulos Comprados: %d",articulos);
 		printf("\n\nPrecio Unitario Del Articulo: %.2lf" ,precio);
 		
 		printf("\n\nSubtotal: %.2lf" ,subtotal);
 		printf("\n\nImpuesto Sobre La Venta: 15 Porciento");
 		printf("\n\nTotal A Pagar: %.2lf",totalpagar);
 		
 
 		
 		
 	
 		return 0;
	 }
