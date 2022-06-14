//Total a pagar en caja
#include<stdio.h>
#include<windows.h>
 main()
 
 	{
 		int articulos; //Articulos , porque solo pide un tipo de articulo
 		double totalpagar, precio ,subtotal ,tp;
 		float imp, descuento;
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
 		
 		if(subtotal<=3000)
 				{
 			descuento=0.05;
			totalpagar=subtotal-(subtotal*descuento);	 }
 		else 
 				{
 			descuento=0.09;
			totalpagar=subtotal-(subtotal*descuento);	 }
 		
 		printf("\n\n");
 		
 		if(articulos>=15)
 			{
 			imp=0.20;
			 tp=totalpagar+(totalpagar*imp);	}
		
 		else 
 			{
 			imp=0.07;
			 tp=totalpagar+(totalpagar*imp); }
 			
 		
 		system("pause");
 		system("cls");
 		
 	
 		
 			
 		printf("\n\tFactura");
 		printf("\n\t*******");
 		
 		printf("\n\nNombre Del Cliente: %s",nomclien);
 		printf("\n\nNombre Del Articulo Comprado: %s",nomar);
 		
 		printf("\n\nCantidad de Articulos Comprados: %d",articulos);
 		printf("\n\nPrecio Unitario Del Articulo: %.2lf" ,precio);
 		
 		printf("\n\nSubtotal: %.2lf" ,subtotal);
 		printf("\n\nImpuesto Sobre La Venta: %.2f" ,imp);
 		printf("\n\nDescuento: %.2f" ,descuento);
 		printf("\n\nTotal A Pagar: %.2lf",tp);
 		
 
 		
 		
 	
 		return 0;
	 }
