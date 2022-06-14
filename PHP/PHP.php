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

    echo "El indice de masa corporal de una persona es: " . imc(70, 1.70);

    echo "<br>";
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

    echo "El indice de masa corporal de una persona es: " . imc(70, 1.70) . " y su estado es: " . estado(imc(70, 1.70));

    echo "<br>";

#ejercicio que calcule el peso ideal de una eprsona segun el peso y altura que se ingrese
    function pesoIdeal($peso, $altura){
        $resultado = $peso / ($altura * $altura);
        return $resultado;
    }

    echo "El peso ideal de una persona con un peso de 70kg y una altura de 1.70m es: " . pesoIdeal(70, 1.70);

    echo "<br>";


    #ejercicio que diga la cantidad de letras que tiene la palabra ingresada
    function cantidadLetras($palabra){
        $resultado = strlen($palabra);
        return $resultado;
    }

    echo "La cantidad de letras que tiene la palabra 'Hola' es: " . cantidadLetras("Hola");

    echo "<br>";

    #ejercicio que diga segun imc si la persona padece un trastorno alimentario , si esta se encuentra en bajo peso categorizarla en anorexia nerviosa , si esta esta en obesidad categorizarlo en obesidad tipo 1 , si esta en obesidad tipo 2 o si esta en obesidad tipo 3 categorizarlo en trastorno por atracon , en caso de estar en normal categorizarlo en saludable
    function trastorno($imc){
        if($imc < 18.5){
            $estado = "Anorexia nerviosa";
        }elseif($imc >= 18.5 && $imc <= 24.9){
            $estado = "Saludable";
        }elseif($imc >= 25 && $imc <= 29.9){
            $estado = "Trastorno por atracon";
        }elseif($imc >= 30 && $imc <= 34.9){
            $estado = "Trastorno por atracon";
        }elseif($imc >= 35 && $imc <= 39.9){
            $estado = "Trastorno por atracon";
        }elseif($imc >= 40){
            $estado = "Trastorno por atracon";
        }
        return $estado;
    }

    echo "El indice de masa corporal de una persona es: " . imc(70, 1.70) . " y su estado es: " . trastorno(imc(70, 1.70));

    echo "<br>";

    #ejercicio que diga si un numero es par o impar

    function par($num){
        if($num % 2 == 0){
            $resultado = "El numero es par";
        }else{
            $resultado = "El numero es impar";
        }
        return $resultado;
    }

    echo "El numero 10 es: " . par(10);

    echo "<br>";

?>

