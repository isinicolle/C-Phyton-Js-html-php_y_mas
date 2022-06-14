/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package paquete;

/**
 *
 * @author Isis Zapata
 */
public class Revistaa extends Biblioteca {

    protected static  int numero;
    
    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }
    
   public void caracteristica(int nu)
    {
        numero = nu;
    }
   
   public String toString()
    {
        return " Numero de revista: "+numero;
    }
}
