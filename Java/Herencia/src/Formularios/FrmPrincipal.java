
package Formularios;

import Clases.ClsEstudiante; //Importar la clase


public class FrmPrincipal extends javax.swing.JFrame {

    public FrmPrincipal() {
        initComponents();
    }
    
    ClsEstudiante est = new ClsEstudiante();

    public void cargarDatos()
    {
        est.setCodigo(Integer.parseInt(txtcodigo.getText()));
        est.setNombre(txtnombre.getText());
        est.setApellido(txtapellido.getText());
        //est.setEdad(Integer.parseInt(spedad.getValue()));
        est.setEdad((int)spedad.getValue()); //Conversion Implicita
    }
   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        txtcodigo = new javax.swing.JTextField();
        txtnombre = new javax.swing.JTextField();
        txtapellido = new javax.swing.JTextField();
        spedad = new javax.swing.JSpinner();
        btncolegio = new javax.swing.JButton();
        btnuniversidad = new javax.swing.JButton();
        btnlimpiar = new javax.swing.JButton();
        btnsalir = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Estudiantes");
        setBackground(new java.awt.Color(153, 255, 255));
        getContentPane().setLayout(null);

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel1.setText("Datos Generales");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(130, 20, 160, 22);

        jLabel2.setText("Codigo:");
        getContentPane().add(jLabel2);
        jLabel2.setBounds(26, 70, 44, 16);

        jLabel3.setText("Nombre:");
        getContentPane().add(jLabel3);
        jLabel3.setBounds(26, 112, 50, 16);

        jLabel4.setText("Apellido:");
        getContentPane().add(jLabel4);
        jLabel4.setBounds(30, 160, 50, 16);

        jLabel5.setText("Edad:");
        getContentPane().add(jLabel5);
        jLabel5.setBounds(30, 210, 33, 16);
        getContentPane().add(txtcodigo);
        txtcodigo.setBounds(88, 67, 80, 22);
        getContentPane().add(txtnombre);
        txtnombre.setBounds(90, 110, 80, 22);
        getContentPane().add(txtapellido);
        txtapellido.setBounds(90, 160, 80, 22);

        spedad.setModel(new javax.swing.SpinnerNumberModel(6, 6, 80, 1));
        getContentPane().add(spedad);
        spedad.setBounds(90, 210, 45, 22);

        btncolegio.setText("Colegio");
        btncolegio.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btncolegioActionPerformed(evt);
            }
        });
        getContentPane().add(btncolegio);
        btncolegio.setBounds(229, 66, 100, 25);

        btnuniversidad.setText("Universidad");
        btnuniversidad.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnuniversidadActionPerformed(evt);
            }
        });
        getContentPane().add(btnuniversidad);
        btnuniversidad.setBounds(229, 108, 99, 25);

        btnlimpiar.setText("Limpiar");
        btnlimpiar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnlimpiarActionPerformed(evt);
            }
        });
        getContentPane().add(btnlimpiar);
        btnlimpiar.setBounds(229, 154, 100, 25);

        btnsalir.setText("Salir");
        btnsalir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnsalirActionPerformed(evt);
            }
        });
        getContentPane().add(btnsalir);
        btnsalir.setBounds(229, 202, 100, 25);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btncolegioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btncolegioActionPerformed
        
        cargarDatos(); //Llamada al metodo
        
        FrmColegio cole = new FrmColegio(); //Instancia al form
        
        cole.setVisible(true); //Mostrar el form
        
    }//GEN-LAST:event_btncolegioActionPerformed

    private void btnlimpiarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnlimpiarActionPerformed
        
        txtcodigo.setText(null);
        txtnombre.setText(null);
        txtapellido.setText(null);
        spedad.setValue(6);
        
    }//GEN-LAST:event_btnlimpiarActionPerformed

    private void btnsalirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnsalirActionPerformed
        
        System.exit(0);
        
    }//GEN-LAST:event_btnsalirActionPerformed

    private void btnuniversidadActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnuniversidadActionPerformed
        cargarDatos();
        
        FrmUniversitarios uni = new FrmUniversitarios();
        
        uni.setVisible(true);
        
    }//GEN-LAST:event_btnuniversidadActionPerformed

    
    public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrmPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btncolegio;
    private javax.swing.JButton btnlimpiar;
    private javax.swing.JButton btnsalir;
    private javax.swing.JButton btnuniversidad;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JSpinner spedad;
    private javax.swing.JTextField txtapellido;
    private javax.swing.JTextField txtcodigo;
    private javax.swing.JTextField txtnombre;
    // End of variables declaration//GEN-END:variables
}
