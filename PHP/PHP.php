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


#segun categoria ingresada se le cobre el pasaje , si es menor a 12 años se le cobra $100, si es mayor a 12 años y menor a 18 años se le cobra $150, si es mayor a 18 años se le cobra $200
    function pasaje($edad){
        if($edad < 12){
            $resultado = 100;
        }elseif($edad >= 12 && $edad < 18){
            $resultado = 150;
        }elseif($edad >= 18){
            $resultado = 200;
        }
        return $resultado;
    }

    echo "El pasaje de una persona con edad de 12 años es: " . pasaje(12);

    echo "<br>";

    #ejercicio que diga si un numero es primo o no
    function primo($num){
        $contador = 0;
        for($i = 1; $i <= $num; $i++){
            if($num % $i == 0){
                $contador++;
            }
        }
        if($contador == 2){
            $resultado = "El numero es primo";
        }else{
            $resultado = "El numero no es primo";
        }
        return $resultado;
    }

    echo "El numero 7 es: " . primo(7);

    echo "<br>";

#ejercicio de pedir cantidad de personas a votar y mostrar la cantidad de votos que recibieron cada una de las personas
    function votos($cantidad){
        $contador = 0;
        for($i = 1; $i <= $cantidad; $i++){
            echo "Ingrese su voto: ";
            $voto = fgets(STDIN);
            if($voto == 1){
                $contador++;
            }
        }
        return $contador;
    }

    echo "La cantidad de votos que recibieron las personas es: " . votos(5);

    echo "<br>";

#ejercicio que muestre la cantidad de personas a votar y la cantidad de presidentes para votar , meustre en un histograma en consolas cuantas personas votaron por los presidentes , el resultado final debe concordar con la cantidad de personas que fue ingresadas para votar
    function presidentes($cantidad){
        $contador = 0;
        for($i = 1; $i <= $cantidad; $i++){
            echo "Ingrese su voto: ";
            $voto = fgets(STDIN);
            if($voto == 1){
                $contador++;
            }
        }
        return $contador;
    }

    echo "La cantidad de votos que recibieron las personas es: " . presidentes(5);

    echo "<br>";

#pedir por consola una cantidad de personas , luego en una estructura qu econtenga nombre,apellido y edad rellenar los datos de la cantidad de persoans ingresadas previamente
    function persona($cantidad){
        $personas = array();
        for($i = 1; $i <= $cantidad; $i++){
            echo "Ingrese su nombre: ";
            $nombre = fgets(STDIN);
            echo "Ingrese su apellido: ";
            $apellido = fgets(STDIN);
            echo "Ingrese su edad: ";
            $edad = fgets(STDIN);
            $personas[$i] = array("nombre" => $nombre, "apellido" => $apellido, "edad" => $edad);
        }
        return $personas;
    }

    echo "La cantidad de personas que ingresaron es: " . count(persona(5));

    echo "<br>";
#mostrar los datos de resultado del ejercicio anterior en una tabla
    function mostrar($personas){
        echo "<table border='1'>";
        echo "<tr>";
        echo "<td>Nombre</td>";
        echo "<td>Apellido</td>";
        echo "<td>Edad</td>";
        echo "</tr>";
        foreach($personas as $persona){
            echo "<tr>";
            echo "<td>" . $persona["nombre"] . "</td>";
            echo "<td>" . $persona["apellido"] . "</td>";
            echo "<td>" . $persona["edad"] . "</td>";
            echo "</tr>";
        }
        echo "</table>";
    }

    mostrar(persona(5));

    echo "<br>";

#pedir por consola una cantidad de personas , luego en una estructura qu econtenga nombre,apellido y edad rellenar los datos de la cantidad de persoans ingresadas previamente al final mostrarlos una tabla en pantalla
    function persona2($cantidad){
        $personas = array();
        for($i = 1; $i <= $cantidad; $i++){
            echo "Ingrese su nombre: ";
            $nombre = fgets(STDIN);
            echo "Ingrese su apellido: ";
            $apellido = fgets(STDIN);
            echo "Ingrese su edad: ";
            $edad = fgets(STDIN);
            $personas[$i] = array("nombre" => $nombre, "apellido" => $apellido, "edad" => $edad);
        }
        return $personas;
    }
#falta la tabla de los datos ingresados
    function mostrar2($personas){
        echo "<table border='1'>";
        echo "<tr>";
        echo "<td>Nombre</td>";
        echo "<td>Apellido</td>";
        echo "<td>Edad</td>";
        echo "</tr>";
        foreach($personas as $persona){
            echo "<tr>";
            echo "<td>" . $persona["nombre"] . "</td>";
            echo "<td>" . $persona["apellido"] . "</td>";
            echo "<td>" . $persona["edad"] . "</td>";
            echo "</tr>";
        }
        echo "</table>";
    }

    mostrar2(persona2(5));

#almacenar en local storage los datos anteriores
    function persona3($cantidad){
        $personas = array();
        for($i = 1; $i <= $cantidad; $i++){
            echo "Ingrese su nombre: ";
            $nombre = fgets(STDIN);
            echo "Ingrese su apellido: ";
            $apellido = fgets(STDIN);
            echo "Ingrese su edad: ";
            $edad = fgets(STDIN);
            $personas[$i] = array("nombre" => $nombre, "apellido" => $apellido, "edad" => $edad);
        }
        return $personas;
    }



?>

