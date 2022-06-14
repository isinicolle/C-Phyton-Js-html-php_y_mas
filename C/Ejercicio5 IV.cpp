#include<stdio.h>
#include<windows.h>
main()
{
	char*msj, op;
	char nombre [20];
	float total , subtotal, precio;
	const float imp=0.15;
	int min;
	 
	printf("\n\tServicio de llamadas telefonicas");
	printf("\n\t******** ** ******** ***********");
	
	printf("\nIngrese su nombre: ");
	scanf("%s",nombre);
	
	printf("\n\nIngrese la cantidad de minutos de la llamada: ");
	scanf("%d",&min);
	
	printf("\n\nCodigo   Tipo de llamada");
	printf("\n[L]......Llamadas LOCALES.\n[N]......Llamadas NACIONALES.\n[I]......INTERNACIONALES");
	
	printf("\n\nIngrese el codigo del tipo de llamada: ");
	scanf("%s",&op);
	
	
	switch (op) {
		case 'L':
				msj="Tipo de llamada realizada: Local";
				if(min<=5) {
				subtotal=1.00;
				total=1.00+(1.00 *imp); }
			else {
			precio=0.30;
			subtotal=min*precio;
			total=subtotal+(subtotal*imp);
			total=total+1.00; }
		break;
		case 'l':
			msj="Tipo de llamada realizada: Local";
				if(min<=5) {
				subtotal=1.00;
				total=1.00+(1.00 *imp); }
			else {
			precio=0.30;
			subtotal=min*precio;
			total=subtotal+(subtotal*imp);
			total=total+1.00; }
		break;
		case 'N':
			msj="Tipo de llamada realizada: Nacional";
			if(min<=3) {
				subtotal=6.00;
				total=6.00+(6.00*imp); }
			else {
			precio=1.00;
			subtotal=min*precio;
			total=subtotal+(subtotal*imp);
			total=total+6.00; }
		break;
		case 'n':
			msj="Tipo de llamada realizada: Nacional";
			if(min<=3) {
				subtotal=6.00;
				total=6.00+(6.00*imp); }
			else {
			precio=1.00;
			subtotal=min*precio;
			total=subtotal+(subtotal*imp);
			total=total+6.00; }
		break;
		case 'i':
			msj="Tipo de llamada realizada: Internacional";
			if(min<=3) {
				subtotal=9.00;
				total=9.00+(9.00*imp); }
			else {
			precio=2.00;
			subtotal=min*precio;
			total=subtotal+(subtotal*imp);
			total=total+9.00; }
		break;
		case 'I':
			msj="Tipo de llamada realizada: Internacional";
			if(min<=3) {
				subtotal=9.00;
				total=9.00+(9.00*imp); }
			else {
			precio=2.00;
			subtotal=min*precio;
			total=subtotal+(subtotal*imp);
			total=total+9.00; }
		break;
	default: printf("\nkk");}
	
	system ("pause");
	system("cls");
	
	printf("\n\tFactura");
	printf("\n\nNombre del cliente: %s" ,nombre);
	printf("\n\n%s",msj);
	printf("\n\nMinutos Hablados: %d",min);	
	printf("\n\nSubtotal a pagar: %.2f",subtotal );	
	printf("\n\nImpuesto: 15");
	printf("\n\nTotal a pagar: %2.f",total );	

	
	return 0;
}
