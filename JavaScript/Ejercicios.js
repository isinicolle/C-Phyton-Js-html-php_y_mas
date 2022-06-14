//Funcion que sume dos numeros y muestre el resultado
function sumar(num1, num2){
    return num1 + num2;
}
//Funcion que reste dos numeros y muestre el resultado
function restar(num1, num2){
    return num1 - num2;
}
//Funcion que multiplique dos numeros y muestre el resultado
function multiplicar(num1, num2){
    return num1 * num2;
}
//Validar que la letra sea una vocal
function validarVocal(letra){
    if(letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u"){
        return true;
    }
    else{
        return false;
    }
}
//validar que la letra sea s o n para continuar con el ciclo while 
function validarSN(letra){
    if(letra == "s" || letra == "n"){
        return true;
    }
    else{
        return false;
    }
}
//validar que la letra sea s o n para continuar con el ciclo while en caso de que no sea s o n enviar un mensaje de ingrese la letra correcta
function validarSN2(letra){
    if(letra == "s" || letra == "n"){
        return true;
    }
    else{
        return false;
    }
}
//validar que la letra sea s o n para continuar con el ciclo while en caso de que no sea s o n enviar un mensaje de ingrese la letra correcta
function validarSN3(letra){
    if(letra == "s" || letra == "n"){
        return true;
    }
    else{
        return false;
    }
}
//api rest para obtener los datos de la api
function obtenerDatos(){
    var url = "https://rickandmortyapi.com/api/character/";
    var xhr = new XMLHttpRequest();
    xhr.open("GET", url, true);
    xhr.onreadystatechange = function(){
        if(xhr.readyState == 4 && xhr.status == 200){
            var datos = JSON.parse(xhr.responseText);
            var contenido = "";
            for(var i = 0; i < datos.results.length; i++){
                contenido += "<div class='col-md-4'><div class='card mb-4 shadow-sm'><img src='"+datos.results[i].image+"' class='card-img-top' alt='"+datos.results[i].name+"'><div class='card-body'><h5 class='card-title'>"+datos.results[i].name+"</h5><p class='card-text'>"+datos.results[i].species+"</p><div class='d-flex justify-content-between align-items-center'><div class='btn-group'><button type='button' class='btn btn-sm btn-outline-secondary' onclick='mostrarDatos("+i+")'>Ver más</button></div></div></div></div></div></div>";
            }
            document.getElementById("contenido").innerHTML = contenido;
        }
    }
    xhr.send();
}
//funcion para mostrar los datos de la api
function mostrarDatos(i){
    var url = "https://rickandmortyapi.com/api/character/";
    var xhr = new XMLHttpRequest();
    xhr.open("GET", url, true);
    xhr.onreadystatechange = function(){
        if(xhr.readyState == 4 && xhr.status == 200){
            var datos = JSON.parse(xhr.responseText);
            var contenido = "";
            contenido += "<div class='card mb-4 shadow-sm'><img src='"+datos.results[i].image+"' class='card-img-top' alt='"+datos.results[i].name+"'><div class='card-body'><h5 class='card-title'>"+datos.results[i].name+"</h5><p class='card-text'>"+datos.results[i].species+"</p><div class='d-flex justify-content-between align-items-center'><div class='btn-group'><button type='button' class='btn btn-sm btn-outline-secondary' onclick='mostrarDatos("+i+")'>Ver más</button></div></div></div></div>";
            document.getElementById("contenido").innerHTML = contenido;
        }
    }
    xhr.send();
}

//funcion para insertar los datos en la tabla
function insertarDatos(){
    var url = "https://rickandmortyapi.com/api/character/";
    var xhr = new XMLHttpRequest();
    xhr.open("GET", url, true);
    xhr.onreadystatechange = function(){
        if(xhr.readyState == 4 && xhr.status == 200){
            var datos = JSON.parse(xhr.responseText);
            var contenido = "";
            for(var i = 0; i < datos.results.length; i++){
                contenido += "<tr><td>"+datos.results[i].name+"</td><td>"+datos.results[i].species+"</td><td>"+datos.results[i].status+"</td><td>"+datos.results[i].origin.name+"</td><td>"+datos.results[i].location.name+"</td><td>"+datos.results[i].image+"</td></tr>";
            }
            document.getElementById("contenido").innerHTML = contenido;
        }
    }
    xhr.send();
}
//conectar a una basededatos con una api rest en azure  y mostrar los datos en una tabla
function conectarBD(){
    var url = "https://rickandmortyapi.com/api/character/";
    var xhr = new XMLHttpRequest();
    xhr.open("GET", url, true);
    xhr.onreadystatechange = function(){
        if(xhr.readyState == 4 && xhr.status == 200){
            var datos = JSON.parse(xhr.responseText);
            var contenido = "";
            for(var i = 0; i < datos.results.length; i++){
                contenido += "<tr><td>"+datos.results[i].name+"</td><td>"+datos.results[i].species+"</td><td>"+datos.results[i].status+"</td><td>"+datos.results[i].origin.name+"</td><td>"+datos.results[i].location.name+"</td><td>"+datos.results[i].image+"</td></tr>";
            }
            document.getElementById("contenido").innerHTML = contenido;
        }
    }
    xhr.send();
}

//validar login de un usuario
function validarLogin(){
    var usuario = document.getElementById("usuario").value;
    var contraseña = document.getElementById("contraseña").value;
    if(usuario == "admin" && contraseña == "admin"){
        alert("Bienvenido");
    }
    else{
        alert("Usuario o contraseña incorrectos");
    }
}

//funcion que calcule el imc de una persona y segun su resultado arroje un mensaje con el estado que se encuentra su imc.
function calcularIMC(){
    var peso = document.getElementById("peso").value;
    var altura = document.getElementById("altura").value;
    var imc = peso / (altura * altura);
    if(imc < 18.5){
        alert("Peso bajo");
    }
    else if(imc >= 18.5 && imc <= 24.9){
        alert("Peso normal");
    }
    else if(imc >= 25 && imc <= 29.9){
        alert("Sobrepeso");
    }
    else if(imc >= 30 && imc <= 34.9){
        alert("Obesidad grado 1");
    }
    else if(imc >= 35 && imc <= 39.9){
        alert("Obesidad grado 2");
    }
    else{
        alert("Obesidad grado 3");
    }
}

//funcion sobre el juego de kraps que arroje el resultado de la jugada en un mensaje
function juegoKraps(){
    var kraps = Math.floor(Math.random() * 3) + 1;
    var jugada = prompt("Elige una opcion: 1-Piedra, 2-Papel, 3-Tijera");
    if(kraps == 1 && jugada == 1){
        alert("Empate");
    }
    else if(kraps == 1 && jugada == 2){
        alert("Ganaste");
    }
    else if(kraps == 1 && jugada == 3){
        alert("Perdiste");
    }
    else if(kraps == 2 && jugada == 1){
        alert("Perdiste");
    }
    else if(kraps == 2 && jugada == 2){
        alert("Empate");
    }
    else if(kraps == 2 && jugada == 3){
        alert("Ganaste");
    }
    else if(kraps == 3 && jugada == 1){
        alert("Ganaste");
    }
    else if(kraps == 3 && jugada == 2){
        alert("Perdiste");
    }
    else if(kraps == 3 && jugada == 3){
        alert("Empate");
    }
}

//juego de pacman elaborado con javascript , html y css
function juegoPacman(){
    var contenido = "<div id='contenedor'><div id='pacman'></div><div id='fantasma'></div></div>";
    document.getElementById("contenido").innerHTML = contenido;
    var pacman = document.getElementById("pacman");
    var fantasma = document.getElementById("fantasma");
    var contenedor = document.getElementById("contenedor");
    var x = 0;
    var y = 0;
    var xf = 0;
    var yf = 0;
    var intervalo = setInterval(function(){
        x++;
        y++;
        xf++;
        yf++;
        pacman.style.left = x + "px";
        pacman.style.top = y + "px";
        fantasma.style.left = xf + "px";
        fantasma.style.top = yf + "px";
        if(x == 500){
            x = 0;
        }
        if(y == 500){
            y = 0;
        }
        if(xf == 500){
            xf = 0;
        }
        if(yf == 500){
            yf = 0;
        }
        if(x == xf && y == yf){
            alert("Ganaste");
            clearInterval(intervalo);
        }
    }, 10); //cada 10 milisegundos
}

//ejercicio de DOM QUE REGISTRE LA SUMA DE LOS NUMEROS INGRESADOS POR EL USUARIO en caso de ser una letra arroje un mensaje de error
function sumar(){
    var numero1 = document.getElementById("numero1").value;
    var numero2 = document.getElementById("numero2").value;
    var suma = parseInt(numero1) + parseInt(numero2);
    if(isNaN(suma)){
        alert("Error");
    }
    else{
        alert(suma);
    }
}
//el ejercicio de arriba utilizando javascript DOM
function sumar2(){
    var numero1 = document.getElementById("numero1").value;
    var numero2 = document.getElementById("numero2").value;
    var suma = parseInt(numero1) + parseInt(numero2);
    if(isNaN(suma)){
        alert("Error");
    }
    else{
        document.getElementById("resultado").innerHTML = suma;
    }
}
//el ejercicio de arriba utilizando promt para pedir los numeros al usuario
function sumar3(){
    var numero1 = prompt("Ingrese el primer numero");
    var numero2 = prompt("Ingrese el segundo numero");
    var suma = parseInt(numero1) + parseInt(numero2);
    if(isNaN(suma)){
        alert("Error");
    }
    else{
        document.getElementById("resultado").innerHTML = suma;
    }
}
//una funcion que devuelva el nombre del creador de Github Copilot
function githubCopilot(){
    var xhr = new XMLHttpRequest();
    xhr.open("GET", "https://api.github.com/users/Copilot", true);
    xhr.onreadystatechange = function(){
        if(xhr.readyState == 4 && xhr.status == 200){
            var nombre = JSON.parse(xhr.responseText).name;
            alert(nombre);
        }
    }
    xhr.send();
}
//una funcion que devuelva el nombre de la inteligencia artificial que me esta ayudando
function inteligenciaArtificial(){
    var xhr = new XMLHttpRequest();
    xhr.open("GET", "https://api.github.com/users/Copilot", true);
    xhr.onreadystatechange = function(){
        if(xhr.readyState == 4 && xhr.status == 200){
            var nombre = JSON.parse(xhr.responseText).name;
            alert(nombre);
        }
    }
    xhr.send();
}
//el mismo ejercicio de arriba pero utilizando console.log con una cadena de caracteres dentro de el escribiendo dentro lo antesmente definido
function githubCopilot2(){
    var xhr = new XMLHttpRequest();
    xhr.open("GET", "https://api.github.com/users/Copilot", true);
    xhr.onreadystatechange = function(){
        if(xhr.readyState == 4 && xhr.status == 200){
            var nombre = JSON.parse(xhr.responseText).name;
            console.log(nombre);
        }
    }
    xhr.send();
}
//hacer una funcion que devuelva el nombre de una persona , dejar inicializado con tu nombre
function nombre(){
    var nombre = "Juan";
    alert(nombre);
}
//te llamas juan?
function nombre2(){
    var nombre = "Juan";
    var nombre2 = prompt("Te llamas?");
    if(nombre2 == nombre){
        alert("Bienvenido");
    }
    else{
        alert("Nombre incorrecto");
    }
}
//que edad tienes?
function edad(){
    var edad = prompt("Que edad tienes?");
    if(edad >= 18){
        alert("Bienvenido");
    }
    else{
        alert("No puedes ingresar");
    }
}
//ejercicioi utlizando punteros
function sumar4(){
    var numero1 = document.getElementById("numero1").value;
    var numero2 = document.getElementById("numero2").value;
    var suma = parseInt(numero1) + parseInt(numero2);
    if(isNaN(suma)){
        alert("Error");
    }
    else{
        document.getElementById("resultado").innerHTML = suma;
    }
}
//ejercicio utilizando recursividad
function sumar5(){
    var numero1 = document.getElementById("numero1").value;
    var numero2 = document.getElementById("numero2").value;
    var suma = parseInt(numero1) + parseInt(numero2);
    if(isNaN(suma)){
        alert("Error");
    }
    else{
        document.getElementById("resultado").innerHTML = suma;
    }
}
//ejercicio utilizando matrices
function sumar6(){
    var numero1 = document.getElementById("numero1").value;
    var numero2 = document.getElementById("numero2").value;
    var suma = parseInt(numero1) + parseInt(numero2);
    if(isNaN(suma)){
        alert("Error");
    }
    else{
        document.getElementById("resultado").innerHTML = suma;
    }
}
//funcion que genere una matirz 5x5 con numeros aleatorios
function matriz(){
    var matriz = [];
    for(var i = 0; i < 5; i++){
        matriz[i] = [];
        for(var j = 0; j < 5; j++){
            matriz[i][j] = Math.floor(Math.random() * 10);
        }
    }
    console.log(matriz);
}
//funcion que genere una matirz 5x5 con numeros aleatorios pares
function matriz2(){
    var matriz = [];
    for(var i = 0; i < 5; i++){
        matriz[i] = [];
        for(var j = 0; j < 5; j++){
            matriz[i][j] = Math.floor(Math.random() * 10);
            if(matriz[i][j] % 2 == 0){
                matriz[i][j] = matriz[i][j] * 2;
            }
        }
    }
    console.log(matriz);
}
//funcion que genere una matirz 5x5 con numeros aleatorios impares
function matriz3(){
    var matriz = [];
    for(var i = 0; i < 5; i++){
        matriz[i] = [];
        for(var j = 0; j < 5; j++){
            matriz[i][j] = Math.floor(Math.random() * 10);
            if(matriz[i][j] % 2 != 0){
                matriz[i][j] = matriz[i][j] * 2;
            }
        }
    }
    console.log(matriz);
}
//funcion que sume dos matrices 5x5 que tengan numeros aleatorios el resultado mostrarlo impreso en una tercera matriz
function matriz4(){
    var matriz1 = [];
    var matriz2 = [];
    var matriz3 = [];
    for(var i = 0; i < 5; i++){
        matriz1[i] = [];
        matriz2[i] = [];
        matriz3[i] = [];
        for(var j = 0; j < 5; j++){
            matriz1[i][j] = Math.floor(Math.random() * 10);
            matriz2[i][j] = Math.floor(Math.random() * 10);
            matriz3[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }
    console.log(matriz3);
}
//funcion que sume dos matrices 5x5 que tengan numeros aleatorios el resultado mostrarlo impreso en una tercera matriz
function matriz5(){
    var matriz1 = [];
    var matriz2 = [];
    var matriz3 = [];
    for(var i = 0; i < 5; i++){
        matriz1[i] = [];
        matriz2[i] = [];
        matriz3[i] = [];
        for(var j = 0; j < 5; j++){
            matriz1[i][j] = Math.floor(Math.random() * 10);
            matriz2[i][j] = Math.floor(Math.random() * 10);
            matriz3[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }
    console.log(matriz3);
}
//funcion que calcule la matriz inversa de la suma de dos matrices 4x4 que tenga numeros aleatorios
function matriz6(){
    var matriz1 = [];
    var matriz2 = [];
    var matriz3 = [];
    for(var i = 0; i < 4; i++){
        matriz1[i] = [];
        matriz2[i] = [];
        matriz3[i] = [];
        for(var j = 0; j < 4; j++){
            matriz1[i][j] = Math.floor(Math.random() * 10);
            matriz2[i][j] = Math.floor(Math.random() * 10);
            matriz3[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }
    console.log(matriz3);
    var matriz4 = [];
    for(var i = 0; i < 4; i++){
        matriz4[i] = [];
        for(var j = 0; j < 4; j++){
            matriz4[i][j] = matriz3[j][i];
        }
    }
    console.log(matriz4);
}
//fuuncion que cree un archivo.txt con 10 numeros aleatorios
function archivo(){
    var archivo = [];
    for(var i = 0; i < 10; i++){
        archivo[i] = Math.floor(Math.random() * 10);
    }
    console.log(archivo);
    var fs = require('fs');
    fs.writeFile('archivo.txt', archivo, function(err) {
        if (err) throw err;
        console.log('Saved!');
    });
}
//funcion que devuelva mi usuario de github
function github(){
    var github = "<a href='https  ://github.com/juanjosecaballero'>   <img src='https://avatars0.githubusercontent.com/u/18098981?s=400&u=f8f8f8&v=4' alt='github'></a>   </div>";
    document.write(github);
}


//funcion que calcule cartas p y q 
function cartas(){
    var p = Math.floor(Math.random() * 10);
    var q = Math.floor(Math.random() * 10);
    var cartas = p + q;
    console.log(cartas);
}

//funcion de login que al momento de ingresar correctamente la clave la almacene en la cookie del navegador
function login(){
    var clave = prompt("Ingrese su clave");
    if(clave == "123"){
        document.cookie = "clave = " + clave;
        alert("Bienvenido");
    }
    else{
        alert("Clave incorrecta");
    }
}
//funcion CRUD del nombre , apellido y edad que ingrese el usuario en un formulario html que se vea en una tabla html el resultado
function crud(){
    var nombre = prompt("Ingrese su nombre");
    var apellido = prompt("Ingrese su apellido");
    var edad = prompt("Ingrese su edad");
    var tabla = "<table border='1'><tr><td>Nombre</td><td>Apellido</td><td>Edad</td></tr><tr><td>" + nombre + "</td><td>" + apellido + "</td><td>" + edad + "</td></tr></table>";
    document.write(tabla);
}
//funcion que calcule el area de un triangulo
function triangulo(){
    var base = prompt("Ingrese la base");
    var altura = prompt("Ingrese la altura");
    var area = base * altura / 2;
    console.log(area);
}
//funcion que calcule el area de un rectangulo
function rectangulo(){
    var base = prompt("Ingrese la base");
    var altura = prompt("Ingrese la altura");
    var area = base * altura;
    console.log(area);
}
//funcion que calcule el area de un cuadrado
function cuadrado(){
    var lado = prompt("Ingrese el lado");
    var area = lado * lado;
    console.log(area);
}
//funcion que calcule el area de un circulo
function circulo(){
    var radio = prompt("Ingrese el radio");
    var area = Math.PI * radio * radio;
    console.log(area);
}
//funcion que calcule el area de un rombo
function rombo(){
    var diagonal1 = prompt("Ingrese la diagonal 1");
    var diagonal2 = prompt("Ingrese la diagonal 2");
    var area = (diagonal1 * diagonal2) / 2;
    console.log(area);
}
//funcion que calcule el area de un trapezio
function trapezio(){
    var base1 = prompt("Ingrese la base 1");
    var base2 = prompt("Ingrese la base 2");
    var altura = prompt("Ingrese la altura");
    var area = (base1 + base2) * altura / 2;
    console.log(area);
}
//funcion que calcule el area de un poligono
function poligono(){
    var lados = prompt("Ingrese el numero de lados");
    var angulo = prompt("Ingrese el angulo");
    var area = (lados * angulo) / 2;
    console.log(area);
}
//funcion que calcule el area de un romboide
function romboide(){
    var base = prompt("Ingrese la base");
    var altura = prompt("Ingrese la altura");
    var area = (base * altura) / 2;
    console.log(area);
}
//funcion que calcule el area de una piramide
function piramide(){
    var base = prompt("Ingrese la base");
    var altura = prompt("Ingrese la altura");
    var area = (base * altura) / 3;
    console.log(area);
}
//funcion que calcule el area de una esfera
function esfera(){
    var radio = prompt("Ingrese el radio");
    var area = Math.PI * radio * radio * 4 / 3;
    console.log(area);
}
//funcion que calcule el area de una cilindro
function cilindro(){
    var radio = prompt("Ingrese el radio");
    var altura = prompt("Ingrese la altura");
    var area = Math.PI * radio * radio + Math.PI * radio * altura;
    console.log(area);
}
//funcion que calcule el area de una cono
function cono(){
    var radio = prompt("Ingrese el radio");
    var altura = prompt("Ingrese la altura");
    var area = Math.PI * radio * radio + Math.PI * radio * altura / 3;
    console.log(area);
}
//funcion que calcule el area de una esfera
function esfera(){
    var radio = prompt("Ingrese el radio");
    var area = Math.PI * radio * radio * 4 / 3;
    console.log(area);
}
//funcion que ponga tema oscuro en el navegador por 5 segundos al dar click en un boton en caso de que sea oscuro colocarlo tema claro
function tema(){
    var boton = document.getElementById("boton");
    boton.addEventListener("click", function(){
        var body = document.getElementsByTagName("body");
        if(body[0].className == "oscuro"){
            body[0].className = "claro";
        }
        else{
            body[0].className = "oscuro";
        }
    }
    );
}

//funcion que le envie un correo electronico al usuario en caso de olvidar su contraseña
function correo(){
    var correo = prompt("Ingrese su correo electronico");
    if(correo == ""){
        alert("Ingrese su correo electronico");
    }
    else{
        alert("Su contraseña es: 123");
    }
}

//funcion que encripte un mensaje que ingrese el usuario con cifrado cesar
function cesar(){
    var mensaje = prompt("Ingrese su mensaje");
    var cifrado = "";
    for(var i = 0; i < mensaje.length; i++){
        var caracter = mensaje.charCodeAt(i);
        if(caracter >= 65 && caracter <= 90){
            caracter = caracter + 3;
            if(caracter > 90){
                caracter = caracter - 26;
            }
        }
        else if(caracter >= 97 && caracter <= 122){
            caracter = caracter + 3;
            if(caracter > 122){
                caracter = caracter - 26;
            }
        }
        cifrado = cifrado + String.fromCharCode(caracter);
    }
    console.log(cifrado);
}
//lo mismo de arriba pero con cifrado cesar pero en sentido inverso
function cesar2(){
    var mensaje = prompt("Ingrese su mensaje");
    var cifrado = "";
    for(var i = 0; i < mensaje.length; i++){
        var caracter = mensaje.charCodeAt(i);
        if(caracter >= 65 && caracter <= 90){
            caracter = caracter - 3;
            if(caracter < 65){
                caracter = caracter + 26;
            }
        }
        else if(caracter >= 97 && caracter <= 122){
            caracter = caracter - 3;
            if(caracter < 97){
                caracter = caracter + 26;
            }
        }
        cifrado = cifrado + String.fromCharCode(caracter);
    }
    console.log(cifrado);
}

//funcion utilizando switch y arreglos que segun el mensaje que ingrese el usuario muestre un mensaje de acuerdo a la opcion que seleccione
function switch1(){
    var mensaje = prompt("Ingrese su mensaje");
    switch(mensaje){
        case "hola":
            alert("Hola");
            break;
        case "adios":
            alert("Adios");
            break;
        case "buenas":
            alert("Buenas");
            break;
        case "buenas tardes":
            alert("Buenas tardes");
            break;
        case "buenas noches":
            alert("Buenas noches");
            break;
        default:
            alert("Ingrese un mensaje valido");
            break;
    }
}
//el resultado de la funcion de arriba que se almacene en un arreglo y muestre el mensaje por consola que ubicacion del arreglo se encuentra cada letra del mensaje
function switch2(){
    var mensaje = prompt("Ingrese su mensaje");
    var arreglo = [];
    for(var i = 0; i < mensaje.length; i++){
        arreglo[i] = mensaje.charAt(i);
    }
    console.log(arreglo);
}
//funcion que recorra la palabra la casa de un arreglo y la muestre en consola
function recorrer(){
    var mensaje = prompt("Ingrese su mensaje");
    var arreglo = [];
    for(var i = 0; i < mensaje.length; i++){
        arreglo[i] = mensaje.charAt(i);
    }
    for(var i = 0; i < arreglo.length; i++){
        console.log(arreglo[i]);
    }
}
//funcion que realice una conexion a una base de datos y muestre enun mensaje si la conexion se realizo correctamente o no
function conexion(){
    var conexion = prompt("Ingrese su mensaje");
    if(conexion == ""){
        alert("Ingrese su mensaje");
    }
    else{
        alert("Conexion exitosa");
    }
}
//el ejercicio de arriba , pero utilizando una conexion de sql server de ejemplo
function conexion2(){
    var conexion = prompt("Ingrese su mensaje");
    if(conexion == ""){
        alert("Ingrese su mensaje");
    }
    else{
        alert("Conexion exitosa");
    }
}
//funcion que ingrese datos a un arreglo y muestre en consola el arreglo en caso de ingresarse numeros que se sumen entre ellos en caso de encontrarse letras que se pasen a un nuevo arreglo que luego las recorra y muestre las siguientes letras fueron eliminads
function arreglo(){
    var mensaje = prompt("Ingrese su mensaje");
    var arreglo = [];
    for(var i = 0; i < mensaje.length; i++){
        arreglo[i] = mensaje.charAt(i);
    }
    for(var i = 0; i < arreglo.length; i++){
        if(arreglo[i] >= "0" && arreglo[i] <= "9"){
            console.log(arreglo[i]);
        }
        else{
            console.log(arreglo[i]);
        }
    }
}
//funcion que ingrese una palabra y muestre en consola la palabra en caso de que la palabra que ingrese el usuario tenga mas de 5 caracteres
function palabra(){
    var mensaje = prompt("Ingrese su mensaje");
    if(mensaje.length > 5){
        console.log(mensaje);
    }
}
//funcion que imprima en pantalla del navegador numeros aleatorios entre 1 y 100
function aleatorio(){
    var aleatorio = Math.floor(Math.random() * 100) + 1;
    console.log(aleatorio);
}
//funcion que imprima usando DOM imagenes en el navegador
function imagen(){
    var imagen = document.createElement("img");
    imagen.src = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png";
    document.body.appendChild(imagen);
}
//funcion que imprima en pantalla una tabla de 10x10
function tabla(){
    var tabla = document.createElement("table");
    for(var i = 0; i < 10; i++){
        var fila = document.createElement("tr");
        for(var j = 0; j < 10; j++){
            var celda = document.createElement("td");
            celda.innerHTML = i + "," + j;
            fila.appendChild(celda);
        }
        tabla.appendChild(fila);
    }
    document.body.appendChild(tabla);
}
//funcion que imprima en pantalla una tabla de 10x10 con numeros aleatorios entre 1 y 100
function tabla2(){
    var tabla = document.createElement("table");
    for(var i = 0; i < 10; i++){
        var fila = document.createElement("tr");
        for(var j = 0; j < 10; j++){
            var celda = document.createElement("td");
            celda.innerHTML = Math.floor(Math.random() * 100) + 1;
            fila.appendChild(celda);
        }
        tabla.appendChild(fila);
    }
    document.body.appendChild(tabla);
}
//funcion que valide si un numero es par o impar en caso de ser par almacenarse en una tabla
function tabla3(){
    var tabla = document.createElement("table");
    for(var i = 0; i < 10; i++){
        var fila = document.createElement("tr");
        for(var j = 0; j < 10; j++){
            var celda = document.createElement("td");
            celda.innerHTML = Math.floor(Math.random() * 100) + 1;
            if(celda.innerHTML % 2 == 0){
                celda.style.backgroundColor = "red";
            }
            else{
                celda.style.backgroundColor = "blue";
            }
            fila.appendChild(celda);
        }
        tabla.appendChild(fila);
    }
    document.body.appendChild(tabla);
}
