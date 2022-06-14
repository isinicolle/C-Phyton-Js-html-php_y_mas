<?php 
#Escribir un programa que sume dos números y muestre el resultado.
    $num1 = 10;
    $num2 = 20;
    $resultado = $num1 + $num2;
    echo "El resultado de la suma es: $resultado";

    echo "<br>";
#Escribir una funcion que reciba dos números y devuelva el resultado de la suma.
    function suma($num1, $num2){
        $resultado = $num1 + $num2;
        return $resultado;
    }

    echo "El resultado de la suma es: " . suma(10, 20);

    echo "<br>";

#escribir una funcion que calcule el logaritmo del numero que se le pase como parametro.
    function logaritmo($num){
        $resultado = log($num);
        return $resultado;
    }

    echo "El logaritmo de 10 es: " . logaritmo(10);

    echo "<br>";
    
#calcular la potencia de dos numeros que se pasen como parametros.
    function potencia($num1, $num2){
        $resultado = pow($num1, $num2);
        return $resultado;
    }

    echo "La potencia de 10 elevado a 2 es: " . potencia(10, 2);

    echo "<br>";

#calcular la raiz de un numero que se pase como parametro.
    function raiz($num){
        $resultado = sqrt($num);
        return $resultado;
    }

    echo "La raiz cuadrada de 100 es: " . raiz(100);

    echo "<br>";

#calcular el indice de masa corporal de una persona y mostrar en un mensaje el resultado de su estado actual

    function imc($peso, $altura){
        $resultado = $peso / ($altura * $altura);
        return $resultado;
    }
#con el ejercicio anterior segundo el resultado del imc mostrar un  mensaje en que rango se encuentra su imc.
    function estado($imc){
        if($imc < 18.5){
            $estado = "Peso bajo";
        }elseif($imc >= 18.5 && $imc <= 24.9){
            $estado = "Peso normal";
        }elseif($imc >= 25 && $imc <= 29.9){
            $estado = "Sobrepeso";
        }elseif($imc >= 30 && $imc <= 34.9){
            $estado = "Obesidad grado 1";
        }elseif($imc >= 35 && $imc <= 39.9){
            $estado = "Obesidad grado 2";
        }elseif($imc >= 40){
            $estado = "Obesidad grado 3";
        }
        return $estado;
    }

    
?>

