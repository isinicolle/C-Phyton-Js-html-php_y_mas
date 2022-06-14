
package ejerciico3;

import java.text.DecimalFormat;
import java.util.Scanner;


public class EJERCIICO3 {

   
    public static void main(String[] args) 
    {
      DecimalFormat ndec= new DecimalFormat("#.00");
      Scanner scan = new Scanner (System.in);
      
      
      String nombre;
      int edad;
      char genero;
      double peso, estat, imc;
      
        System.out.println("\t\t Indice de masa corporal");
        System.out.print("Ingrese el nombre: ");
        nombre=scan.nextLine();
        System.out.print("Ingrese la edad: ");
        edad=scan.nextInt();
        System.out.print("Ingrese su genero: ");
        genero=scan.next().charAt(0);
        genero=Character.toUpperCase(genero);
        
        System.out.print("Ingrese su peso: ");
        peso=scan.nextDouble();
        System.out.print("Ingrese su estatura: ");
        estat=scan.nextDouble();
        
        imc=peso/(estat* estat);
        System.out.println("\t\t DATOS INGRESADOS");
        System.out.println("Su nombre es: "+nombre);
        System.out.println("Su geenro es: "+genero);
        System.out.println("Su edad es: "+edad);
        System.out.println("Su peso es: "+ndec.format(peso));
        System.out.println("Su estatura es: "+ndec.format(estat));
        System.out.println("Su Indice de masa corporal es: "+ndec.format(imc));
        
    }
    
}
