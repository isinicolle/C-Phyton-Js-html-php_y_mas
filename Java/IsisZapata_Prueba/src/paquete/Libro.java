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
public class Libro extends Biblioteca {

   protected static  String prestado;
    
    public String getPrestado() {
        return prestado;
    }

    public void setPrestado(String prestado) {
        this.prestado = prestado;
    }
    
    public void caracteristica(String estado)
    {
        prestado = estado;
    }
    
    
    public String toString()
    {
        return " Estado del libro: "+prestado;
    }
}
