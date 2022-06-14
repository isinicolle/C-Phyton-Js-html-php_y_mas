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


#horario de la pelicula segun la hora de la reserva  (hora de la reserva, hora de la pelicula, hora de la pelicula + duracion de la pelicula)
    function horario_pelicula(){
        echo "Introduce la hora de la reserva: "; #pide la hora de la reserva 
        $hora_reserva = trim(fgets(STDIN)); #guarda la hora de la reserva  (hora de la reserva)
        echo "Introduce la hora de la pelicula: "; #pide la hora de la pelicula  (hora de la pelicula)
        $hora_pelicula = trim(fgets(STDIN)); #guarda la hora de la pelicula  (hora de la pelicula) 
        echo "Introduce la duracion de la pelicula: "; #pide la duracion de la pelicula  (duracion de la pelicula)
        $duracion_pelicula = trim(fgets(STDIN)); #guarda la duracion de la pelicula  (duracion de la pelicula) 
        $hora_pelicula_final = $hora_pelicula + $duracion_pelicula; #calcula la hora de la pelicula final  (hora de la pelicula + duracion de la pelicula)
        if($hora_reserva >= $hora_pelicula && $hora_reserva <= $hora_pelicula_final){ #si la hora de la reserva esta entre la hora de la pelicula y la hora de la pelicula + duracion de la pelicula 
            echo "La pelicula se empieza a ver a las $hora_pelicula y durara $duracion_pelicula horas."; #muestra la hora de la pelicula y la duracion de la pelicula
        }else{ #si la hora de la reserva no esta entre la hora de la pelicula y la hora de la pelicula + duracion de la pelicula 
            echo "La pelicula no se empieza a ver a las $hora_pelicula y durara $duracion_pelicula horas."; #muestra la hora de la pelicula y la duracion de la pelicula
        } #si la hora de la reserva no esta entre la hora de la pelicula y la hora de la pelicula + duracion de la pelicula 
    } #fin de la funcion horario_pelicula

#combo de palomitas y bebidas segun edad aplicar descuento 
    function combo_palomitas_bebidas(){ #funcion combo_palomitas_bebidas
        echo "Introduce tu edad: "; #pide la edad 
        $edad = trim(fgets(STDIN)); #guarda la edad 
        if($edad >= 18 && $edad <= 65){ #si la edad esta entre 18 y 65 
            echo "El precio del combo de palomitas y bebidas es de 10 euros."; #muestra el precio del combo de palomitas y bebidas 
        }else{ #si la edad no esta entre 18 y 65 
            echo "El precio del combo de palomitas y bebidas es de 5 euros."; #muestra el precio del combo de palomitas y bebidas 
        } #si la edad no esta entre 18 y 65 
    } #fin de la funcion combo_palomitas_bebidas 

#llenar datos si se paga con tarjeta de credito guardar datos en un array e imprimir los datos en una tabla que se guarde en un archivo
    function tarjeta_credito(){ #funcion tarjeta_credito
        $datos = array(); #array para guardar los datos 
        echo "Introduce tu nombre: "; #pide el nombre 
        $nombre = trim(fgets(STDIN)); #guarda el nombre  (nombre)
        echo "Introduce tu apellido: "; #pide el apellido
        $apellido = trim(fgets(STDIN)); #guarda el apellido  (apellido)
        echo "Introduce tu numero de tarjeta de credito: "; #pide el numero de tarjeta de credito
        $numero_tarjeta = trim(fgets(STDIN)); #guarda el numero de tarjeta de credito  (numero de tarjeta de credito)
        echo "Introduce tu codigo de seguridad: "; #pide el codigo de seguridad
        $codigo_seguridad = trim(fgets(STDIN)); #guarda el codigo de seguridad  (codigo de seguridad)
        echo "Introduce tu mes de vencimiento: "; #pide el mes de vencimiento
        $mes_vencimiento = trim(fgets(STDIN)); #guarda el mes de vencimiento  (mes de vencimiento)
        echo "Introduce tu anio de vencimiento: "; #pide el anio de vencimiento
        $anio_vencimiento = trim(fgets(STDIN)); #guarda el anio de vencimiento  (anio de vencimiento)
        $datos = array($nombre, $apellido, $numero_tarjeta, $codigo_seguridad, $mes_vencimiento, $anio_vencimiento); #guarda los datos en un array
        $archivo = fopen("tarjeta_credito.txt", "a"); #abre el archivo tarjeta_credito.txt para escribir en el archivo
        fwrite($archivo, $datos[0]."\n"); #escribe el nombre en el archivo tarjeta_credito.txt
        fwrite($archivo, $datos[1]."\n"); #escribe el apellido en el archivo tarjeta_credito.txt
        fwrite($archivo, $datos[2]."\n"); #escribe el numero de tarjeta de credito en el archivo tarjeta_credito.txt
        fwrite($archivo, $datos[3]."\n"); #escribe el codigo de seguridad en el archivo tarjeta_credito.txt
        fwrite($archivo, $datos[4]."\n"); #escribe el mes de vencimiento en el archivo tarjeta_credito.txt
        fwrite($archivo, $datos[5]."\n"); #escribe el anio de vencimiento en el archivo tarjeta_credito.txt
        fclose($archivo); #cierra el archivo tarjeta_credito.txt
        $archivo = fopen("tarjeta_credito.txt", "r"); #abre el archivo tarjeta_credito.txt para leer el archivo
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Nombre</td><td>Apellido</td><td>Numero de tarjeta de credito</td><td>Codigo de seguridad</td><td>Mes de vencimiento</td><td>Anio de vencimiento</td></tr>"; #muestra la tabla con los datos
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            echo "<tr><td>$linea</td></tr>"; #muestra la linea del archivo 
        } #mientras no se llegue al final del archivo
        echo "</table>"; #cierra la tabla
        fclose($archivo); #cierra el archivo tarjeta_credito.txt 
    } #fin de la funcion tarjeta_credito


#llenar datos de un contacto guardar datos en un array e imprimir los datos en una tabla que se guarde en un archivo
    function contacto(){ #funcion contacto
        $datos = array(); #array para guardar los datos 
        echo "Introduce tu nombre: "; #pide el nombre 
        $nombre = trim(fgets(STDIN)); #guarda el nombre  (nombre)
        echo "Introduce tu apellido: "; #pide el apellido
        $apellido = trim(fgets(STDIN)); #guarda el apellido  (apellido)
        echo "Introduce tu numero de telefono: "; #pide el numero de telefono
        $numero_telefono = trim(fgets(STDIN)); #guarda el numero de telefono  (numero de telefono)
        echo "Introduce tu email: "; #pide el email
        $email = trim(fgets(STDIN)); #guarda el email  (email)
        $datos = array($nombre, $apellido, $numero_telefono, $email); #guarda los datos en un array
        $archivo = fopen("contacto.txt", "a"); #abre el archivo contacto.txt para escribir en el archivo
        fwrite($archivo, $datos[0]."\n"); #escribe el nombre en el archivo contacto.txt
        fwrite($archivo, $datos[1]."\n"); #escribe el apellido en el archivo contacto.txt
        fwrite($archivo, $datos[2]."\n"); #escribe el numero de telefono en el archivo contacto.txt
        fwrite($archivo, $datos[3]."\n"); #escribe el email en el archivo contacto.txt
        fclose($archivo); #cierra el archivo contacto.txt
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Nombre</td><td>Apellido</td><td>Numero de telefono</td><td>Email</td></tr>"; #muestra la tabla con los datos
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            echo "<tr><td>$linea</td></tr>"; #muestra la linea del archivo 
        } #mientras no se llegue al final del archivo
        echo "</table>"; #cierra la tabla
        fclose($archivo); #cierra el archivo contacto.txt
    } #fin de la funcion contacto


#almacenar la fecha y hora de una llamada guardar datos en un array guardar los datos en un archivo y sobreescribir el archivo añadiendo informacion nueva al final de este
    function llamada(){ #funcion llamada  

        $datos = array(); #array para guardar los datos
        echo "Introduce tu nombre: "; #pide el nombre
        $nombre = trim(fgets(STDIN)); #guarda el nombre  (nombre)
        echo "Introduce tu apellido: "; #pide el apellido
        $apellido = trim(fgets(STDIN)); #guarda el apellido  (apellido)
        echo "Introduce tu numero de telefono: "; #pide el numero de telefono
        $numero_telefono = trim(fgets(STDIN)); #guarda el numero de telefono  (numero de telefono)
        echo "Introduce tu email: "; #pide el email
        $email = trim(fgets(STDIN)); #guarda el email  (email)
        echo "Introduce tu fecha de llamada: "; #pide la fecha de llamada
        $fecha_llamada = trim(fgets(STDIN)); #guarda la fecha de llamada  (fecha de llamada)
        echo "Introduce tu hora de llamada: "; #pide la hora de llamada
        $hora_llamada = trim(fgets(STDIN)); #guarda la hora de llamada  (hora de llamada)
        $datos = array($nombre, $apellido, $numero_telefono, $email, $fecha_llamada, $hora_llamada); #guarda los datos en un array
        $archivo = fopen("llamada.txt", "a"); #abre el archivo llamada.txt para escribir en el archivo
        fwrite($archivo, $datos[0]."\n"); #escribe el nombre en el archivo llamada.txt
        fwrite($archivo, $datos[1]."\n"); #escribe el apellido en el archivo llamada.txt
        fwrite($archivo, $datos[2]."\n"); #escribe el numero de telefono en el archivo llamada.txt
        fwrite($archivo, $datos[3]."\n"); #escribe el email en el archivo llamada.txt
        fwrite($archivo, $datos[4]."\n"); #escribe la fecha de llamada en el archivo llamada.txt
        fwrite($archivo, $datos[5]."\n"); #escribe la hora de llamada en el archivo llamada.txt
        fclose($archivo); #cierra el archivo llamada.txt
        $archivo = fopen("llamada.txt", "r"); #abre el archivo llamada.txt para leer el archivo
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Nombre</td><td>Apellido</td><td>Numero de telefono</td><td>Email</td><td>Fecha de llamada</td><td>Hora de llamada</td></tr>"; #muestra la tabla con los datos
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            echo "<tr><td>$linea</td></tr>"; #muestra la linea del archivo 
        } #mientras no se llegue al final del archivo
        echo "</table>"; #cierra la tabla
        fclose($archivo); #cierra el archivo llamada.txt
    } #fin de la funcion llamada

#cargar en una tabla los datos de un archivo y mostrarla en pantalla
    function contacto_archivo(){ #funcion contacto_archivo  
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Nombre</td><td>Apellido</td><td>Numero de telefono</td><td>Email</td></tr>"; #muestra la tabla con los datos
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            echo "<tr><td>$linea</td></tr>"; #muestra la linea del archivo 
        } #mientras no se llegue al final del archivo
        echo "</table>"; #cierra la tabla
        fclose($archivo); #cierra el archivo contacto.txt
    } #fin de la funcion contacto_archivo 

#borrar los datos de una fila de una tabla 
    function borrar_contacto(){ #funcion borrar_contacto  
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Nombre</td><td>Apellido</td><td>Numero de telefono</td><td>Email</td></tr>"; #muestra la tabla con los datos
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            echo "<tr><td>$linea</td></tr>"; #muestra la linea del archivo 
        } #mientras no se llegue al final del archivo
        echo "</table>"; #cierra la tabla
        fclose($archivo); #cierra el archivo contacto.txt
        echo "Introduce el numero de telefono que deseas borrar: "; #pide el numero de telefono que deseas borrar
        $numero_telefono = trim(fgets(STDIN)); #guarda el numero de telefono  (numero de telefono)
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        $archivo_nuevo = fopen("contacto_nuevo.txt", "a"); #abre el archivo contacto_nuevo.txt para escribir en el archivo
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            if($linea != $numero_telefono."\n"){ #si la linea no es igual al numero de telefono 
                fwrite($archivo_nuevo, $linea); #escribe la linea en el archivo contacto_nuevo.txt
            } #si la linea no es igual al numero de telefono 
        } #mientras no se llegue al final del archivo
        fclose($archivo); #cierra el archivo contacto.txt 
        fclose($archivo_nuevo); #cierra el archivo contacto_nuevo.txt
        unlink("contacto.txt"); #borra el archivo contacto.txt
        rename("contacto_nuevo.txt", "contacto.txt"); #renombra el archivo contacto_nuevo.txt a contacto.txt
    } #fin de la funcion borrar_contacto

#convertir archivo a pdf
    function convertir_pdf(){ #funcion convertir_pdf  
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Nombre</td><td>Apellido</td><td>Numero de telefono</td><td>Email</td></tr>"; #muestra la tabla con los datos
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            echo "<tr><td>$linea</td></tr>"; #muestra la linea del archivo 
        } #mientras no se llegue al final del archivo
        echo "</table>"; #cierra la tabla
        fclose($archivo); #cierra el archivo contacto.txt
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        $archivo_nuevo = fopen("contacto_nuevo.txt", "a"); #abre el archivo contacto_nuevo.txt para escribir en el archivo
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            fwrite($archivo_nuevo, $linea); #escribe la linea en el archivo contacto_nuevo.txt
        } #mientras no se llegue al final del archivo
        fclose($archivo); #cierra el archivo contacto.txt
        fclose($archivo_nuevo); #cierra el archivo contacto_nuevo.txt
        unlink("contacto.txt"); #borra el archivo contacto.txt
        rename("contacto_nuevo.txt", "contacto.txt"); #renombra el archivo contacto_nuevo.txt a contacto.txt
    } #fin de la funcion convertir_pdf

#convertir archivo .txt a archivo binario
    function convertir_binario(){ #funcion convertir_binario  
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Nombre</td><td>Apellido</td><td>Numero de telefono</td><td>Email</td></tr>"; #muestra la tabla con los datos
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            echo "<tr><td>$linea</td></tr>"; #muestra la linea del archivo 
        } #mientras no se llegue al final del archivo
        echo "</table>"; #cierra la tabla
        fclose($archivo); #cierra el archivo contacto.txt
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        $archivo_nuevo = fopen("contacto_nuevo.txt", "a"); #abre el archivo contacto_nuevo.txt para escribir en el archivo
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            fwrite($archivo_nuevo, $linea); #escribe la linea en el archivo contacto_nuevo.txt
        } #mientras no se llegue al final del archivo
        fclose($archivo); #cierra el archivo contacto.txt
        fclose($archivo_nuevo); #cierra el archivo contacto_nuevo.txt
        unlink("contacto.txt"); #borra el archivo contacto.txt
        rename("contacto_nuevo.txt", "contacto.txt"); #renombra el archivo contacto_nuevo.txt a contacto.txt
    } #fin de la funcion convertir_binario


#usar enumerar para guardar listado de productos en un archivo al momento de hacer una compra y mostrarlo en una tabla
    function enumerar(){ #funcion enumerar  
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Nombre</td><td>Apellido</td><td>Numero de telefono</td><td>Email</td></tr>"; #muestra la tabla con los datos
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            echo "<tr><td>$linea</td></tr>"; #muestra la linea del archivo 
        } #mientras no se llegue al final del archivo
        echo "</table>"; #cierra la tabla
        fclose($archivo); #cierra el archivo contacto.txt
        $archivo = fopen("contacto.txt", "r"); #abre el archivo contacto.txt para leer el archivo
        $archivo_nuevo = fopen("contacto_nuevo.txt", "a"); #abre el archivo contacto_nuevo.txt para escribir en el archivo
        while(!feof($archivo)){ #mientras no se llegue al final del archivo 
            $linea = fgets($archivo); #lee la linea del archivo 
            fwrite($archivo_nuevo, $linea); #escribe la linea en el archivo contacto_nuevo.txt
        } #mientras no se llegue al final del archivo
        fclose($archivo); #cierra el archivo contacto.txt
        fclose($archivo_nuevo); #cierra el archivo contacto_nuevo.txt
        unlink("contacto.txt"); #borra el archivo contacto.txt
        rename("contacto_nuevo.txt", "contacto.txt"); #renombra el archivo contacto_nuevo.txt a contacto.txt
    } #fin de la funcion enumerar

#calculadora
    function calculadora(){ #funcion calculadora  
        echo "<form action='calculadora.php' method='post'>"; #abre el formulario
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Numero 1</td><td><input type='text' name='num1'></td></tr>"; #muestra la tabla con los datos
        echo "<tr><td>Numero 2</td><td><input type='text' name='num2'></td></tr>"; #muestra la tabla con los datos
        echo "<tr><td>Operacion</td><td><select name='operacion'>"; #muestra la tabla con los datos
        echo "<option value='suma'>Suma</option>"; #muestra la tabla con los datos
        echo "<option value='resta'>Resta</option>"; #muestra la tabla con los datos
        echo "<option value='multiplicacion'>Multiplicacion</option>"; #muestra la tabla con los datos
        echo "<option value='division'>Division</option>"; #muestra la tabla con los datos
        echo "</select></td></tr>"; #muestra la tabla con los datos
        echo "<tr><td><input type='submit' value='Calcular'></td></tr>"; #muestra la tabla con los datos
        echo "</table>"; #cierra la tabla
        echo "</form>"; #cierra el formulario
    } #fin de la funcion calculadora

#conversion de numeros naturales a binarios
    function binario(){ #funcion binario  
        echo "<form action='binario.php' method='post'>"; #abre el formulario
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Numero</td><td><input type='text' name='num'></td></tr>"; #muestra la tabla con los datos
        echo "<tr><td><input type='submit' value='Convertir'></td></tr>"; #muestra la tabla con los datos
        echo "</table>"; #cierra la tabla
        echo "</form>"; #cierra el formulario
    } #fin de la funcion binario

#convertir numero ingresado a numero binario
    function convertir_binarioo(){ #funcion convertir_binario  
        $num = $_POST['num']; #obtiene el numero ingresado en el formulario
        $num_binario = decbin($num); #convierte el numero ingresado a numero binario y lo guarda en la variable $num_binario
        echo "El numero $num en binario es $num_binario"; #muestra el numero binario 
    } #fin de la funcion convertir_binario 
#mostrar en pantalla el numero ingresado y su conversion en una tabla
    function mostrar_numero(){ #funcion mostrar_numero  
        $num = $_POST['num']; #obtiene el numero ingresado en el formulario
        $num_binario = decbin($num); #convierte el numero ingresado a numero binario y lo guarda en la variable $num_binario
        echo "<table border='1'>"; #abre la tabla
        echo "<tr><td>Numero</td><td>$num</td></tr>"; #muestra la tabla con los datos
        echo "<tr><td>Numero binario</td><td>$num_binario</td></tr>"; #muestra la tabla con los datos
        echo "</table>"; #cierra la tabla
    } #fin de la funcion mostrar_numero

#decir que signo zodiacal es el dia de la fecha ingresada por el usuario
    function zodiacal(){ #funcion zodiacal  
        $dia = $_POST['dia']; #obtiene el dia ingresado en el formulario
        $mes = $_POST['mes']; #obtiene el mes ingresado en el formulario
        $anio = $_POST['anio']; #obtiene el año ingresado en el formulario
        $signo = ""; #declara la variable signo
        if($mes == 1 && $dia <= 20){ #si el mes es 1 y el dia es menor o igual a 20
            $signo = "Capricornio"; #el signo es capricornio
        } #fin de la condicion 
        elseif($mes == 2 && $dia <= 19){ #si el mes es 2 y el dia es menor o igual a 19
            $signo = "Capricornio"; #el signo es capricornio
        } #fin de la condicion  
        elseif($mes == 3 && $dia <= 21){ #si el mes es 3 y el dia es menor o igual a 21
            $signo = "Aries"; #el signo es aries
        } #fin de la condicion 
        elseif($mes == 4 && $dia <= 20){ #si el mes es 4 y el dia es menor o igual a 20
            $signo = "Aries"; #el signo es aries
        } #fin de la condicion 
        elseif($mes == 5 && $dia <= 21){ #si el mes es 5 y el dia es menor o igual a 21
            $signo = "Tauro"; #el signo es tauro
        } #fin de la condicion
        elseif($mes == 6 && $dia <= 21){ #si el mes es 6 y el dia es menor o igual a 21
            $signo = "Tauro"; #el signo es tauro
        } #fin de la condicion
        elseif($mes == 7 && $dia <= 23){ #si el mes es 7 y el dia es menor o igual a 23
            $signo = "Geminis"; #el signo es geminis
        } #fin de la condicion
        elseif($mes == 8 && $dia <= 23){ #si el mes es 8 y el dia es menor o igual a 23
            $signo = "Geminis"; #el signo es geminis
        } #fin de la condicion
        elseif($mes == 9 && $dia <= 23){ #si el mes es 9 y el dia es menor o igual a 23
            $signo = "Cancer"; #el signo es cancer
        } #fin de la condicion 
        elseif($mes == 10 && $dia <= 23){ #si el mes es 10 y el dia es menor o igual a 23
            $signo = "Cancer"; #el signo es cancer
        } #fin de la condicion 
        elseif($mes == 11 && $dia <= 22){ #si el mes es 11 y el dia es menor o igual a 22
            $signo = "Leo"; #el signo es leo
        } #fin de la condicion 
        elseif($mes == 12 && $dia <= 22){ #si el mes es 12 y el dia es menor o igual a 22 
            $signo = "Leo"; #el signo es leo  y muestra el signo en pantalla
        } #fin de la condicion
        else{ #si no cumple ninguna condicion
            $signo = "Fecha incorrecta"; #el signo es incorrecto 
        } #fin de la condicion 
        echo "El signo zodiacal del dia $dia/$mes/$anio es $signo"; #muestra el signo en pantalla 
    } #fin de la funcion zodiacal

 #utilizando poo para crear una clase que calcule el area de una figura 
    class figura{ #clase figura  
        var $base; #declara la variable base
        var $altura; #declara la variable altura
        var $area; #declara la variable area
        function __construct($base, $altura){ #funcion constructor  
            $this->base = $base; #asigna el valor de la base a la variable base
            $this->altura = $altura; #asigna el valor de la altura a la variable altura
        } #fin de la funcion constructor
        function area(){ #funcion area  
            $this->area = $this->base * $this->altura; #calcula el area de la figura y lo guarda en la variable area
        } #fin de la funcion area
        function mostrar_area(){ #funcion mostrar_area  
            echo "El area de la figura es $this->area"; #muestra el area de la figura en pantalla
        } #fin de la funcion mostrar_area
    } #fin de la clase figura   
    $figura = new figura($_POST['base'], $_POST['altura']); #crea una instancia de la clase figura 
    $figura->area(); #llama a la funcion area de la clase figura
    $figura->mostrar_area(); #llama a la funcion mostrar_area de la clase figura

    class calculadora{ #clase calculadora  
        var $num1; #declara la variable num1
        var $num2; #declara la variable num2
        var $resultado; #declara la variable resultado
        function __construct($num1, $num2){ #funcion constructor  
            $this->num1 = $num1; #asigna el valor de num1 a la variable num1
            $this->num2 = $num2; #asigna el valor de num2 a la variable num2
        } #fin de la funcion constructor
        function suma(){ #funcion suma  
            $this->resultado = $this->num1 + $this->num2; #calcula la suma de los numeros y lo guarda en la variable resultado
        } #fin de la funcion suma 
        function resta(){ #funcion resta  
            $this->resultado = $this->num1 - $this->num2; #calcula la resta de los numeros y lo guarda en la variable resultado
        } #fin de la funcion resta
        function multiplicacion(){ #funcion multiplicacion  
            $this->resultado = $this->num1 * $this->num2; #calcula la multiplicacion de los numeros y lo guarda en la variable resultado
        } #fin de la funcion multiplicacion
        function division(){ #funcion division  
            $this->resultado = $this->num1 / $this->num2; #calcula la division de los numeros y lo guarda en la variable resultado
        } #fin de la funcion division
        function mostrar_resultado(){ #funcion mostrar_resultado  
            echo "El resultado de la operacion es $this->resultado"; #muestra el resultado de la operacion en pantalla
        } #fin de la funcion mostrar_resultado
    } #fin de la clase calculadora


#utilizando poo cree una clase llamada libros , utilice herencia para crear una clase llamada libro_fisico que herede de la clase libros , haga lo mismo con otra clase llamada libro_electronico , utilice homonimia para la descripcion de los libros y polimorfismo para los titulos de los libros , sobrecargue metodos de los costos adicionales
    class libros{ #clase libros  
        var $titulo; #declara la variable titulo
        var $autor; #declara la variable autor
        var $descripcion; #declara la variable descripcion
        var $costo; #declara la variable costo
        function __construct($titulo, $autor, $descripcion, $costo){ #funcion constructor  
            $this->titulo = $titulo; #asigna el valor de titulo a la variable titulo
            $this->autor = $autor; #asigna el valor de autor a la variable autor
            $this->descripcion = $descripcion; #asigna el valor de descripcion a la variable descripcion
            $this->costo = $costo; #asigna el valor de costo a la variable costo
        } #fin de la funcion constructor
        function mostrar_titulo(){ #funcion mostrar_titulo  
            echo "El titulo del libro es $this->titulo"; #muestra el titulo del libro en pantalla
        } #fin de la funcion mostrar_titulo
        function mostrar_autor(){ #funcion mostrar_autor  
            echo "El autor del libro es $this->autor"; #muestra el autor del libro en pantalla
        } #fin de la funcion mostrar_autor
        function mostrar_descripcion(){ #funcion mostrar_descripcion  
            echo "La descripcion del libro es $this->descripcion"; #muestra la descripcion del libro en pantalla
        } #fin de la funcion mostrar_descripcion
        function mostrar_costo(){ #funcion mostrar_costo  
            echo "El costo del libro es $this->costo"; #muestra el costo del libro en pantalla
        } #fin de la funcion mostrar_costo
    } #fin de la clase libros
    class libro_fisico extends libros{ #clase libro_fisico que hereda de la clase libros  
        var $descripcion; #declara la variable descripcion
        function __construct($titulo, $autor, $descripcion, $costo){ #funcion constructor  
            parent::__construct($titulo, $autor, $descripcion, $costo); #llama a la funcion constructor de la clase padre
        } #fin de la funcion constructor
        function mostrar_descripcion(){ #funcion mostrar_descripcion  
            echo "La descripcion del libro es $this->descripcion"; #muestra la descripcion del libro en pantalla
        } #fin de la funcion mostrar_descripcion
    } #fin de la clase libro_fisico
    $libro = new libros($_POST['titulo'], $_POST['autor'], $_POST['descripcion'], $_POST['costo']); #crea una instancia de la clase libros
    $libro->mostrar_titulo(); #llama a la funcion mostrar_titulo de la clase libros
    $libro->mostrar_autor(); #llama a la funcion mostrar_autor de la clase libros
    $libro->mostrar_descripcion(); #llama a la funcion mostrar_descripcion de la clase libros
    $libro->mostrar_costo(); #llama a la funcion mostrar_costo de la clase libros
    $libro_fisico = new libro_fisico($_POST['titulo'], $_POST['autor'], $_POST['descripcion'], $_POST['costo']); #crea una instancia de la clase libro_fisico
    $libro_fisico->mostrar_descripcion(); #llama a la funcion mostrar_descripcion de la clase libro_fisico
#herede ahora una clase para libro_electronico que herede de la clase libros
    class libro_electronico extends libros{ #clase libro_electronico que herede de la clase libros  
        var $descripcion; #declara la variable descripcion
        function __construct($titulo, $autor, $descripcion, $costo){ #funcion constructor  
            parent::__construct($titulo, $autor, $descripcion, $costo); #llama a la funcion constructor de la clase padre
        } #fin de la funcion constructor
        function mostrar_descripcion(){ #funcion mostrar_descripcion  
            echo "La descripcion del libro es $this->descripcion"; #muestra la descripcion del libro en pantalla
        } #fin de la funcion mostrar_descripcion
    } #fin de la clase libro_electronico
    $libro_electronico = new libro_electronico($_POST['titulo'], $_POST['autor'], $_POST['descripcion'], $_POST['costo']); #crea una instancia de la clase libro_electronico
    $libro_electronico->mostrar_descripcion(); #llama a la funcion mostrar_descripcion de la clase libro_electronico

#cree un formulario que llene los datos de la clase libro
    echo "<form action='calculadora.php' method='post'>"; #abre el formulario
    echo "<label>Titulo:</label>"; #muestra el label titulo
    echo "<input type='text' name='titulo'><br>"; #muestra el input titulo
    echo "<label>Autor:</label>"; #muestra el label autor
    echo "<input type='text' name='autor'><br>"; #muestra el input autor
    echo "<label>Descripcion:</label>"; #muestra el label descripcion
    echo "<input type='text' name='descripcion'><br>"; #muestra el input descripcion
    echo "<label>Costo:</label>"; #muestra el label costo
    echo "<input type='text' name='costo'><br>"; #muestra el input costo
    echo "<input type='submit' value='Enviar'>"; #muestra el input submit
    echo "</form>"; #cierra el formulario

    echo "<br>"; #muestra un salto de linea
#cree dos botones que le de a elegir al usuario entre libro fisico o libro electronico y que llame a la funcion que seleccione el tipo de libro segun el boton que selecciono despliegue un formulario para el llenado de datos de su respectiva clase
    echo "<form action='calculadora.php' method='post'>"; #abre el formulario
    echo "<input type='submit' name='tipo_libro' value='Libro Fisico'>"; #muestra el input submit con el valor libro fisico
    echo "</form>"; #cierra el formulario
    echo "<form action='calculadora.php' method='post'>"; #abre el formulario
    echo "<input type='submit' name='tipo_libro' value='Libro Electronico'>"; #muestra el input submit con el valor libro electronico
    echo "</form>"; #cierra el formulario
#si el usuario selecciono el boton libro fisico entonces se despliega un formulario para llenar los datos de la clase libro_fisico
    if(isset($_POST['tipo_libro']) && $_POST['tipo_libro'] == 'Libro Fisico'){ #si el usuario selecciono el boton libro fisico  
        echo "<form action='calculadora.php' method='post'>"; #abre el formulario
        echo "<label>Titulo:</label>"; #muestra el label titulo
        echo "<input type='text' name='titulo'><br>"; #muestra el input titulo
        echo "<label>Autor:</label>"; #muestra el label autor
        echo "<input type='text' name='autor'><br>"; #muestra el input autor
        echo "<label>Descripcion:</label>"; #muestra el label descripcion
        echo "<input type='text' name='descripcion'><br>"; #muestra el input descripcion
        echo "<label>Costo:</label>"; #muestra el label costo
        echo "<input type='text' name='costo'><br>"; #muestra el input costo
        echo "<input type='submit' value='Enviar'>"; #muestra el input submit
        echo "</form>"; #cierra el formulario
    } #fin de la condicion si el usuario selecciono el boton libro fisico
#si el usuario selecciono el boton libro electronico entonces se despliega un formulario para llenar los datos de la clase libro_electronico
    if(isset($_POST['tipo_libro']) && $_POST['tipo_libro'] == 'Libro Electronico'){ #si el usuario selecciono el boton libro electronico  
        echo "<form action='calculadora.php' method='post'>"; #abre el formulario
        echo "<label>Titulo:</label>"; #muestra el label titulo
        echo "<input type='text' name='titulo'><br>"; #muestra el input titulo
        echo "<label>Autor:</label>"; #muestra el label autor
        echo "<input type='text' name='autor'><br>"; #muestra el input autor
        echo "<label>Descripcion:</label>"; #muestra el label descripcion
        echo "<input type='text' name='descripcion'><br>"; #muestra el input descripcion
        echo "<label>Costo:</label>"; #muestra el label costo
        echo "<input type='text' name='costo'><br>"; #muestra el input costo
        echo "<input type='submit' value='Enviar'>"; #muestra el input submit
        echo "</form>"; #cierra el formulario
    } #fin de la condicion si el usuario selecciono el boton libro electronico
#si el usuario selecciono el boton enviar entonces se despliega un formulario para llenar los datos de la clase libro_electronico

#mostrar en pantalla los datos que ingreso del libro y que tipo de libro escogio 
    if(isset($_POST['titulo']) && isset($_POST['autor']) && isset($_POST['descripcion']) && isset($_POST['costo'])){ #si el usuario selecciono el boton enviar  
        echo "<h1>Datos del Libro</h1>"; #muestra el titulo 
        echo "<p>Titulo: ".$_POST['titulo']."</p>"; #muestra el titulo
        echo "<p>Autor: ".$_POST['autor']."</p>"; #muestra el autor
        echo "<p>Descripcion: ".$_POST['descripcion']."</p>"; #muestra la descripcion
        echo "<p>Costo: ".$_POST['costo']."</p>"; #muestra el costo
        echo "<p>Tipo de Libro: ".$_POST['tipo_libro']."</p>"; #muestra el tipo de libro
    } #fin de la condicion si el usuario selecciono el boton enviar
#si el usuario selecciono el boton enviar entonces se despliega un formulario para llenar los datos de la clase libro_electronico

    if(isset($_POST['tipo_libro']) && $_POST['tipo_libro'] == 'Libro Fisico'){ #si el usuario selecciono el boton libro fisico  
        echo "<form action='calculadora.php' method='post'>"; #abre el formulario
        echo "<label>Titulo:</label>"; #muestra el label titulo
        echo "<input type='text' name='titulo'><br>"; #muestra el input titulo
        echo "<label>Autor:</label>"; #muestra el label autor
        echo "<input type='text' name='autor'><br>"; #muestra el input autor
        echo "<label>Descripcion:</label>"; #muestra el label descripcion
        echo "<input type='text' name='descripcion'><br>"; #muestra el input descripcion
        echo "<label>Costo:</label>"; #muestra el label costo
        echo "<input type='text' name='costo'><br>"; #muestra el input costo
        echo "<input type='submit' value='Enviar'>"; #muestra el input submit
        echo "</form>"; #cierra el formulario
    } #fin de la condicion si el usuario selecciono el boton libro fisico
#si el usuario selecciono el boton libro electronico entonces se despliega un formulario para llenar los datos de la clase libro_electronico
    if(isset($_POST['tipo_libro']) && $_POST['tipo_libro'] == 'Libro Electronico'){ #si el usuario selecciono el boton libro electronico  
        echo "<form action='calculadora.php' method='post'>"; #abre el formulario
        echo "<label>Titulo:</label>"; #muestra el label titulo
        echo "<input type='text' name='titulo'><br>"; #muestra el input titulo
        echo "<label>Autor:</label>"; #muestra el label autor
        echo "<input type='text' name='autor'><br>"; #muestra el input autor
        echo "<label>Descripcion:</label>"; #muestra el label descripcion
        echo "<input type='text' name='descripcion'><br>"; #muestra el input descripcion
        echo "<label>Costo:</label>"; #muestra el label costo
        echo "<input type='text' name='costo'><br>"; #muestra el input costo
        echo "<input type='submit' value='Enviar'>"; #muestra el input submit
        echo "</form>"; #cierra el formulario
    } #fin de la condicion si el usuario selecciono el boton libro electronico
#si el usuario selecciono el boton enviar entonces se despliega un formulario para llenar los datos de la clase libro_electronico

#mostrar al usuario el costo total de los libros que selecciono
    if(isset($_POST['titulo']) && isset($_POST['autor']) && isset($_POST['descripcion']) && isset($_POST['costo'])){ #si el usuario selecciono el boton enviar  
        echo "<h1>Costo Total</h1>"; #muestra el titulo 
        echo "<p>Costo Total: ".$_POST['costo']."</p>"; #muestra el costo total
    } #fin de la condicion si el usuario selecciono el boton enviar
#si el usuario selecciono el boton enviar entonces se despliega un formulario para llenar los datos de la clase libro_electronico

#mostrarle al usaurio un mensaje de agradecimiento por la compra de su libro calcular el descuento segun el tipo de libro que selecciono y su costo entre mas costoso es el descuento mas grande
    if(isset($_POST['titulo']) && isset($_POST['autor']) && isset($_POST['descripcion']) && isset($_POST['costo'])){ #si el usuario selecciono el boton enviar  
        echo "<h1>Agradecimiento</h1>"; #muestra el titulo 
        echo "<p>Gracias por su compra</p>"; #muestra el mensaje de agradecimiento 
        echo "<p>El descuento es de: ".$_POST['costo']."</p>"; #muestra el descuento 
    } #fin de la condicion si el usuario selecciono el boton enviar 
#si el usuario selecciono el boton enviar entonces se despliega un formulario para llenar los datos de la clase libro_electronico

    if(isset($_POST['titulo']) && isset($_POST['autor']) && isset($_POST['descripcion']) && isset($_POST['costo'])){ #si el usuario selecciono el boton enviar  
        echo "<h1>Agradecimiento</h1>"; #muestra el titulo 
        echo "<p>Gracias por su compra</p>"; #muestra el mensaje de agradecimiento 
        echo "<p>El descuento es de: ".$_POST['costo']."</p>"; #muestra el descuento 
    } #fin de la condicion si el usuario selecciono el boton enviar




   


       
?>

