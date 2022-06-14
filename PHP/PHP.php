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

#hacer una tabla que al ingresar los datos nombre y apellido tenga la opcion de editar y eliminar
    function mostrar3($personas){
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

#falta opcion de editar y eliminar
#delete y update

#mostrar en pantalla la palabra gracias por usar el programa
    echo "Gracias por usar el programa";

    echo "<br>";

#funcionq ue muestre el video kill this love de youtube en pantalla
    function video(){
        echo "<iframe width='560' height='315' src='https://www.youtube.com/embed/QH2-TGUlwu4' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";
    }

    video();

    echo "<br>";

#funcion que meustre el video kill this love de youtube en pantalla y lo reproduzca automaticamente
    function video2(){
        echo "<iframe width='560' height='315' src='https://www.youtube.com/embed/QH2-TGUlwu4' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";
    }

#juego de pacman completo usando html y css
    function pacman(){
        echo "<div class='pacman'>";
        echo "<div class='pacman-body'>";
        echo "<div class='pacman-mouth'></div>";
        echo "</div>";
        echo "</div>";
    } 

    pacman();

    echo "<br>";

#test de 5 preguntas con opciones de respuesta y mostrar el resultado en pantalla
    function preguntas(){
        $preguntas = array(
            "¿Quien es el autor de la saga de los tres cuervos?",
            "¿Quien es el autor de la saga de los tres cuervos?",
            "¿Quien es el autor de la saga de los tres cuervos?",
            "¿Quien es el autor de la saga de los tres cuervos?",
            "¿Quien es el autor de la saga de los tres cuervos?"
        );
        $opciones = array(
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien"
        );
        $respuestas = array(
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien"
        );
        $respuestas_correctas = array(
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien"
        );
        $respuestas_incorrectas = array(
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien",
            "J.R.R. Tolkien"
        );
        $respuestas_correctas_usuario = array();
        $respuestas_incorrectas_usuario = array();
        $puntaje = 0;
        for($i = 0; $i < 5; $i++){
            echo $preguntas[$i] . "<br>";
            echo "1. " . $opciones[$i] . "<br>";
            echo "2. " . $opciones[$i + 1] . "<br>";
            echo "3. " . $opciones[$i + 2] . "<br>";
            echo "4. " . $opciones[$i + 3] . "<br>";
            echo "5. " . $opciones[$i + 4] . "<br>";
            echo "Ingrese la respuesta correcta: ";
            $respuesta_usuario = fgets(STDIN);
            if($respuesta_usuario == $respuestas_correctas[$i]){
                $puntaje++;
                $respuestas_correctas_usuario[$i] = $respuestas_correctas[$i];
            }else{
                $respuestas_incorrectas_usuario[$i] = $respuestas_incorrectas[$i];
            }
        }
        echo "Su puntaje es: " . $puntaje;
    }

#examen de matematicas sobre suma de fracciones que muestre el resultado en pantalla segun las respuestas correctas seleccionadas
    function examen(){
        $preguntas = array(
            "¿Cuantas fracciones hay en la suma de dos fracciones?",
            "¿Cuantas fracciones hay en la suma de dos fracciones?",
            "¿Cuantas fracciones hay en la suma de dos fracciones?",
            "¿Cuantas fracciones hay en la suma de dos fracciones?",
            "¿Cuantas fracciones hay en la suma de dos fracciones?"
        );
        $opciones = array(
            "2",
            "2",
            "2",
            "2",
            "2"
        );
        $respuestas = array(
            "2",
            "2",
            "2",
            "2",
            "2"
        );
        $respuestas_correctas = array(
            "2",
            "2",
            "2",
            "2",
            "2"
        );
        $respuestas_incorrectas = array(
            "2",
            "2",
            "2",
            "2",
            "2"
        );
        $respuestas_correctas_usuario = array();
        $respuestas_incorrectas_usuario = array();
        $puntaje = 0;
        for($i = 0; $i < 5; $i++){
            echo $preguntas[$i] . "<br>";
            echo "1. " . $opciones[$i] . "<br>";
            echo "2. " . $opciones[$i + 1] . "<br>";
            echo "3. " . $opciones[$i + 2] . "<br>";
            echo "4. " . $opciones[$i + 3] . "<br>";
            echo "5. " . $opciones[$i + 4] . "<br>";
            echo "Ingrese la respuesta correcta: ";
            $respuesta_usuario = fgets(STDIN);
            if($respuesta_usuario == $respuestas_correctas[$i]){
                $puntaje++;
                $respuestas_correctas_usuario[$i] = $respuestas_correctas[$i];
            }else{
                $respuestas_incorrectas_usuario[$i] = $respuestas_incorrectas[$i];
            }
        }
        echo "Su puntaje es: " . $puntaje;
    }
#juego de x 0 , x la jugara el usuario y el 0 el computador mostrar en pantalla el resultado final y quien gano la partida
#Juego tic tac toe con el usuario y el computador mostrar resultado en pantalla
    function juego(){
        $jugador = array(
            "X",
            "O"
        );
        $computador = array(
            "X",
            "O"
        );
        $tablero = array(
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"
        );
        $turno = 0;
        $ganador = 0;
        $jugada = 0;
        $jugada_computador = 0;
        $jugada_usuario = 0;
        $ganador_usuario = 0;
        $ganador_computador = 0;
        $ganador_empate = 0;
        $ganador_usuario_final = 0;
        $ganador_computador_final = 0;
        $ganador_empate_final = 0;
        $ganador_final = 0;
  

        while($ganador == 0){ #mientras no haya un ganador
            if($turno == 0){ #si es el turno del usuario
                echo "Ingrese la jugada: ";
                $jugada_usuario = fgets(STDIN);
                $jugada_usuario = trim($jugada_usuario);
                if($jugada_usuario == "1" || $jugada_usuario == "2" || $jugada_usuario == "3" || $jugada_usuario == "4" || $jugada_usuario == "5" || $jugada_usuario == "6" || $jugada_usuario == "7" || $jugada_usuario == "8" || $jugada_usuario == "9"){
                    if($tablero[$jugada_usuario] == "X" || $tablero[$jugada_usuario] == "O"){
                        echo "Esa casilla ya esta ocupada, ingrese otra: "; #si la casilla ya esta ocupada
                        $jugada_usuario = fgets(STDIN); #se pide otra jugada
                        $jugada_usuario = trim($jugada_usuario); #se elimina espacios en blanco
                    }
                    $tablero[$jugada_usuario] = "X"; #se coloca el simbolo del usuario en la casilla correspondiente
                    $turno = 1; #se cambia el turno
                }else{  #si la jugada no es valida
                    echo "Ingrese una casilla valida: ";    #se pide otra jugada
                    $jugada_usuario = fgets(STDIN); #se pide otra jugada
                    $jugada_usuario = trim($jugada_usuario);    #se elimina espacios en blanco
                }
            }else{ #si es el turno del computador
                $jugada_computador = rand(0,8); #se genera una jugada aleatoria
                if($tablero[$jugada_computador] == "X" || $tablero[$jugada_computador] == "O"){     #si la casilla ya esta ocupada
                    $jugada_computador = rand(0,8); #se pide otra jugada
                }
                $tablero[$jugada_computador] = "O";     #se coloca el simbolo del computador en la casilla correspondiente
                $turno = 0;
            }
            echo "Tablero: <br>";
            echo "1. " . $tablero[0] . "<br>";
            echo "2. " . $tablero[1] . "<br>";
            echo "3. " . $tablero[2] . "<br>";
            echo "4. " . $tablero[3] . "<br>";
            echo "5. " . $tablero[4] . "<br>";
            echo "6. " . $tablero[5] . "<br>";
            echo "7. " . $tablero[6] . "<br>";
            echo "8. " . $tablero[7] . "<br>";
            echo "9. " . $tablero[8] . "<br>";
            if($tablero[0] == "X" && $tablero[1] == "X" && $tablero[2] == "X"){
                $ganador = 1;
                $ganador_usuario_final = 1;
            }elseif($tablero[3] == "X" && $tablero[4] == "X" && $tablero[5] == "X"){
                $ganador = 1;
                $ganador_usuario_final = 1;
            }elseif($tablero[6] == "X" && $tablero[7] == "X" && $tablero[8] == "X"){
                $ganador = 1;
                $ganador_usuario_final = 1;
            }elseif($tablero[0] == "X" && $tablero[3] == "X" && $tablero[6] == "X"){ #horizontal
                $ganador = 1;
                $ganador_usuario_final = 1; #ganador usuario
            }elseif($tablero[1] == "X" && $tablero[4] == "X" && $tablero[7] == "X"){ #horizontal
                $ganador = 1;
                $ganador_usuario_final = 1; #ganador usuario
            }elseif($tablero[2] == "X" && $tablero[5] == "X" && $tablero[8] == "X"){ #horizontal 
                $ganador = 1; #ganador usuario
                $ganador_usuario_final = 1;
            }elseif($tablero[0] == "X" && $tablero[4] == "X" && $tablero[8] == "X"){ #diagonal
                $ganador = 1;
                $ganador_usuario_final = 1; #ganador usuario
            }elseif($tablero[2] == "X" && $tablero[4] == "X" && $tablero[6] == "X"){ #diagonal
                $ganador = 1;
                $ganador_usuario_final = 1; #ganador usuario
            }elseif($tablero[0] == "O" && $tablero[1] == "O" && $tablero[2] == "O"){
                $ganador = 1;
                $ganador_computador_final = 1; #ganador computador
            }elseif($tablero[3] == "O" && $tablero[4] == "O" && $tablero[5] == "O"){
                $ganador = 1;
                $ganador_computador_final = 1; #ganador computador
            }elseif($tablero[6] == "O" && $tablero[7] == "O" && $tablero[8] == "O"){
                $ganador = 1;
                $ganador_computador_final = 1; #ganador computador
            }elseif($tablero[0] == "O" && $tablero[3] == "O" && $tablero[6] == "O"){ #horizontal
                $ganador = 1;
                $ganador_computador_final = 1; #ganador computador
            }elseif($tablero[1] == "O" && $tablero[4] == "O" && $tablero[7] == "O"){ #horizontal
                $ganador = 1;
                $ganador_computador_final = 1; #ganador computador
            }elseif($tablero[2] == "O" && $tablero[5] == "O" && $tablero[8] == "O"){ #horizontal
                $ganador = 1; #ganador computador
                $ganador_computador_final = 1;
            }elseif($tablero[0] == "O" && $tablero[4] == "O" && $tablero[8] == "O"){ #diagonal
                $ganador = 1;
                $ganador_computador_final = 1; #ganador computador
            }elseif($tablero[2] == "O" && $tablero[4] == "O" && $tablero[6] == "O"){ #diagonal
                $ganador = 1;
                $ganador_computador_final = 1; #ganador computador
            }
            if($ganador == 1){
                if($ganador_usuario_final == 1){
                    echo "Ganador: Usuario";
                }elseif($ganador_computador_final == 1){
                    echo "Ganador: Computador";
                }
            }
            if($ganador == 0){
                $turno = 1;
            }
        }
    }

#programa que muestre los asientos de una sala de cine y que permita reservar un asiento si esta disponible y que muestre el asiento que se ha reservado y el precio de la reserva. El programa debe permitir que el usuario pueda reservar varios asientos.
    function asientos(){   #funcion que muestra los asientos de una sala de cine y que permita reservar un asiento si esta disponible y que muestre el asiento que se ha reservado y el precio de la reserva. El programa debe permitir que el usuario pueda reservar varios asientos.
        $asientos = array("A1" => "Libre", "A2" => "Libre", "A3" => "Libre", "A4" => "Libre", "A5" => "Libre", "A6" => "Libre", "A7" => "Libre", "A8" => "Libre", "A9" => "Libre");
        $asientos_reservados = array(); #array que guarda los asientos reservados
        $precio = 0; #precio de la reserva
        $precio_total = 0; #precio total de la reserva
        $numero_asientos = 0;     #numero de asientos reservados
        $numero_asientos_reservados = 0; #numero de asientos reservados
        $numero_asientos_libres = 9; #numero de asientos libres
        $numero_asientos_reservados_final = 0; #numero de asientos reservados final
        $numero_asientos_libres_final = 9; #numero de asientos libres
        $numero_asientos_reservados_final = 0; #numero de asientos reservados
        $numero_asientos_libres_final = 9; #numero de asientos libres
        $numero_asientos_reservados_final = 0; #numero de asientos reservados
        $numero_asientos_libres_final = 9; #numero de asientos libres

        echo "Asientos disponibles: "; #muestra los asientos disponibles
        foreach($asientos as $asiento => $estado){
            echo $asiento . " ";
        } #muestra los asientos disponibles
        echo "<br>";
        echo "Asientos reservados: "; #muestra los asientos reservados
        foreach($asientos_reservados as $asiento => $estado){
            echo $asiento . " ";
        } #muestra los asientos reservados 

        echo "<br>";
        echo "Asientos libres: "; #muestra los asientos libres 
        foreach($asientos as $asiento => $estado){
            if($estado == "Libre"){
                echo $asiento . " ";
            }
        } #muestra los asientos libres

        echo "<br>";

        while($numero_asientos_reservados_final == 0){ #mientras no se haya reservado ningun asiento
            echo "Introduce el asiento que quieres reservar: ";
            $asiento_reservado = trim(fgets(STDIN));
            if(array_key_exists($asiento_reservado, $asientos)){
                if($asientos[$asiento_reservado] == "Libre"){
                    $asientos[$asiento_reservado] = "Reservado";
                    $asientos_reservados[$asiento_reservado] = "Reservado";
                    $numero_asientos_reservados++;
                    $numero_asientos_libres--;
                    $precio = $numero_asientos_reservados * 10;
                    $precio_total = $precio_total + $precio;
                    echo "Asiento reservado con exito. El precio de la reserva es de $precio euros.";
                }else{
                    echo "El asiento ya esta ocupado.";
                } #si el asiento esta ocupado
            }else{ #si el asiento no existe
                echo "El asiento no existe.";
            } #si el asiento no existe
            echo "<br>";
            echo "Asientos reservados: "; #muestra los asientos reservados
            foreach($asientos_reservados as $asiento => $estado){
                echo $asiento . " ";
            } #muestra los asientos reservados
            echo "<br>";
            echo "Asientos libres: "; #muestra los asientos libres
            foreach($asientos as $asiento => $estado){
                if($estado == "Libre"){
                    echo $asiento . " ";
                }
            } #muestra los asientos libres   
            echo "<br>";    
            if($numero_asientos_libres == 0){
                $numero_asientos_reservados_final = 1;
            } #si no quedan asientos libres
        } #mientras no se haya reservado ningun asiento 
        echo "El precio total de la reserva es de $precio_total euros."; #muestra el precio total de la reserva
    } #fin de la funcion asientos

    function asientos_reservados(){ #funcion que muestra los asientos reservados
        $asientos = array("A1" => "Libre", "A2" => "Libre", "A3" => "Libre", "A4" => "Libre", "A5" => "Libre", "A6" => "Libre", "A7" => "Libre", "A8" => "Libre", "A9" => "Libre");
        $asientos_reservados = array(); #array que guarda los asientos reservados
        $precio = 0; #precio de la reserva
        $precio_total = 0; #precio total de la reserva
        $numero_asientos = 0;     #numero de asientos reservados
        $numero_asientos_reservados = 0; #numero de asientos reservados
        $numero_asientos_libres = 9; #numero de asientos libres
        $numero_asientos_reservados_final = 0; #numero de asientos reservados
        $numero_asientos_libres_final = 9; #numero de asientos libres
        $numero_asientos_reservados_final = 0; #numero de asientos reservados
        $numero_asientos_libres_final = 9; #numero de asientos libres
        $numero_asientos_reservados_final = 0; #numero de asientos reservados
        $numero_asientos_libres_final = 9; #numero de asientos libres

        echo "Asientos disponibles: "; #muestra los asientos disponibles
        foreach($asientos as $asiento => $estado){
            echo $asiento . " ";
        } #muestra los asientos disponibles
        echo "<br>";
        echo "Asientos reservados: "; #muestra los asientos reservados
        foreach($asientos_reservados as $asiento => $estado){
            echo $asiento . " ";
        } #muestra los asientos reservados 

        echo "<br>";
        echo "Asientos libres: "; #muestra los asientos libres
        foreach($asientos as $asiento => $estado){ #muestra los asientos libres
            if($estado == "Libre"){ #si el asiento esta libre
                echo $asiento . " ";
            }
        } #muestra los asientos libres

        echo "<br>"; 
        
        while($numero_asientos_reservados_final == 0){ #mientras no se haya reservado ningun asiento 
            echo "Introduce el asiento que quieres reservar: "; #pide el asiento que quiere reservar
            $asiento_reservado = trim(fgets(STDIN)); #guarda el asiento que quiere reservar 
            if(array_key_exists($asiento_reservado, $asientos)){ #si el asiento existe 
                if($asientos[$asiento_reservado] == "Libre"){ #si el asiento esta libre 
                    $asientos[$asiento_reservado] = "Reservado"; #lo reserva  y lo guarda en el array asientos_reservados  y en el array asientos
                    $asientos_reservados[$asiento_reservado] = "Reservado"; #lo reserva  y lo guarda en el array asientos_reservados  y en el array asientos
                    $numero_asientos_reservados++; #aumenta el numero de asientos reservados
                    $numero_asientos_libres--; #disminuye el numero de asientos libres
                    $precio = $numero_asientos_reservados * 10; #calcula el precio de la reserva
                    $precio_total = $precio_total + $precio; #suma el precio de la reserva al precio total
                    echo "Asiento reservado con exito. El precio de la reserva es de $precio euros."; #muestra el precio de la reserva
                }else{ #si el asiento esta ocupado 
                    echo "El asiento ya esta ocupado.";
                } #si el asiento esta ocupado 
            }else{ #si el asiento no existe 
                echo "El asiento no existe.";
            } #si el asiento no existe  
            echo "<br>"; 
            echo "Asientos reservados: "; #muestra los asientos reservados 
            foreach($asientos_reservados as $asiento => $estado){
                echo $asiento . " ";
            } #muestra los asientos reservados 
            echo "<br>";
            echo "Asientos libres: "; #muestra los asientos libres
            foreach($asientos as $asiento => $estado){
                if($estado == "Libre"){
                    echo $asiento . " ";
                }
            } #muestra los asientos libres 
            echo "<br>";  
            if($numero_asientos_libres == 0){
                $numero_asientos_reservados_final = 1;
            } #si no quedan asientos libres  y se sale del bucle
        } #mientras no se haya reservado ningun asiento  
        echo "El precio total de la reserva es de $precio_total euros."; #muestra el precio total de la reserva 
    } #fin de la funcion asientos_reservados 
    






         



       
?>

