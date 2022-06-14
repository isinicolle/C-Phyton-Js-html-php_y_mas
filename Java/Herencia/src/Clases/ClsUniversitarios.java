

package Clases;


public class ClsUniversitarios extends ClsEstudiante{
    
    private int nota1;
    private int nota2;
    private int nota3;
    private double promedio;
    private String Estado;
    
    public int getNota1() {
        return nota1;
    }

    public void setNota1(int nota1) {
        this.nota1 = nota1;
    }

    public int getNota2() {
        return nota2;
    }

    public void setNota2(int nota2) {
        this.nota2 = nota2;
    }

    public int getNota3() {
        return nota3;
    }

    public void setNota3(int nota3) {
        this.nota3 = nota3;
    }

    public double getPromedio() {
        return promedio;
    }

    public void setPromedio(double promedio) {
        this.promedio = promedio;
    }

    public String getEstado() {
        return Estado;
    }

    public void setEstado(String Estado) {
        this.Estado = Estado;
    }
    
    public void calcularPromedio()
    {
        promedio = (nota1 * 0.25) + (nota2 * 0.35) + (nota3 * 0.4);
    }
    
    public void obtenerEstado()
    {
        if(promedio < 70)
        {
            Estado = "Reprobado";
        }
        else
        {
            Estado = "Aprobado";
        }
    }
    
}
