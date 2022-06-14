public class ClsMamiferos extends Animal{
    
    //Atributos
    private String colorPlumas;
    private String tam;
    private double costoadv;
    
    //Encapsulamiento
    public String getColorPlumas() {
        return colorPlumas;
    }

    public void setColorPlumas(String colorPlumas) {
        this.colorPlumas = colorPlumas;
    }

    public String getTam() {
        return tam;
    }

    public void setTam(String tam) {
        this.tam = tam;
    }

    public double getCostoadv() {
        return costoadv;
    }

    
    public void setCostoadv(double costoadv) {
        this.costoadv = costoadv;
    }
    
    //Metodos
    
    //Polimorfismo
    @Override
    public double calculoSubtotal()
    {
        return 100 + costoadv;
    }
    
    //Polimorfismo
    @Override
    public double calcISV()
    {
        return calculoSubtotal() * 0.15;
    }
    
    //Polimorfismo
    @Override
    public double calculoTotal()
    {
        return calculoSubtotal() + calcISV();
    }