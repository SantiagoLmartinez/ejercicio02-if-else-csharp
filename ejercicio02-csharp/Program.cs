/*
  -Para simular el lanzamiento de tres dados de seis caras. Evaluaremos los valores para calcular
  la puntuación. Si la puntuación es mayor que un total arbitrario, el usuario verá un mensaje de
  que ha ganado. En caso contrario, el usuario verá un mensaje de que ha perdido.
  

  -Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
  -Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
  -Si la suma de los tres dados, junto con los puntos extra, es igual o mayor que 15, gana el juego.
  De lo contrario, pierde.
*/

Random Dado = new Random();
int dado1 = Dado.Next(1, 7);
int dado2 = Dado.Next(1, 7);
int dado3 = Dado.Next(1, 7);
int sumaDados = dado1 + dado2 + dado3;
int totalArbitrario = 15;

Console.WriteLine("----Juego 1----");

//sin anidamiento
/*
if( (dado1 == dado2) || (dado1 == dado3) || (dado2 == dado3) )
{
    Console.WriteLine("2 dados iguales + 2 puntos");
      sumaDados += 2;
    
}
if( (dado1 == dado2) && (dado2 == dado3) )
{
    Console.WriteLine("3 dados iguales + 6 puntos");
    sumaDados +=6;
}

*/

//Con anidamiento 

if ((dado1 == dado2) || (dado1 == dado3) || (dado2 == dado3))
{
    if( (dado1 == dado2) && (dado2 == dado3) )
        {
        Console.WriteLine("3 dados iguales, sumas 6 puntos");
        sumaDados += 6;
    }
    else {
        Console.WriteLine("2 Dados iguales, sumas 2 puntos extras");
        sumaDados += 2;
    }
}

Console.WriteLine("Dado 1 :" + dado1);
Console.WriteLine("Dado 2 :" + dado2);
Console.WriteLine("Dado 3 :" + dado3);

if (sumaDados >= totalArbitrario)
{
    Console.WriteLine("Ganaste con " + sumaDados);
}
else
{
    Console.WriteLine("Perdiste con " + sumaDados);
}

Console.WriteLine("----Juego 2 ----");

/*
 Para que el juego sea más divertido, vamos a cambiar la dinámica de ganar o perder para adjudicar premios ficticios a cada puntuación.
 Ofreceremos cuatro premios. El jugador solo debe ganar un premio:

Si el jugador obtiene una puntuación igual o mayor que 16, gana un coche nuevo.
Si el jugador obtiene una puntuación igual o mayor que 10, gana un portátil nuevo.
Si el jugador obtiene una puntuación de 7, gana un viaje.
De lo contrario, el jugador gana un gatito.
*/

dado1 = Dado.Next(1, 7);
dado2 = Dado.Next(1, 7);
dado3 = Dado.Next(1, 7);

int segundoJuegoPuntaje = dado1 + dado2 + dado3;

Console.WriteLine("Dados segundo juego :"+ dado1  +" - "+ dado2 + " - " + dado3);

if ((dado1 == dado2) || (dado1 == dado3) || (dado2 == dado3))
{
    if ((dado1 == dado2) && (dado2 == dado3))
    {
        Console.WriteLine("3 dados iguales, sumas 6 puntos");
        segundoJuegoPuntaje += 6;
    }
    else
    {
        Console.WriteLine("2 Dados iguales, sumas 2 puntos extras");
        segundoJuegoPuntaje += 2;
    }
}

if (segundoJuegoPuntaje >= 16) {
    Console.WriteLine("Ganaste un coche nuevo" );

}else if(segundoJuegoPuntaje >=10)
{
    Console.WriteLine("Ganaste una Notebook");
}else if (segundoJuegoPuntaje == 7)
{
    Console.WriteLine("Ganaste un gatito");
}
Console.WriteLine("Puntaje del segundo juego:" + segundoJuegoPuntaje);


//Con Funciones
Console.WriteLine("----Juego 3 ----");

dado1 = Dado.Next(1, 7);
dado2 = Dado.Next(1, 7);
dado3 = Dado.Next(1, 7);

int CalcularDados()
{
      if ((dado1 == dado2) || (dado1 == dado3) || (dado2 == dado3))
    {
        if ((dado1 == dado2) && (dado2 == dado3))
        {
            Console.WriteLine("3 dados iguales, sumas 6 puntos");
            segundoJuegoPuntaje += 6;
        }
        else
        {
            Console.WriteLine("2 Dados iguales, sumas 2 puntos extras");
            segundoJuegoPuntaje += 2;
        }
    }

    return 0;
}
CalcularDados();
Console.WriteLine("Dados tercer juego :" + dado1 + " - " + dado2 + " - " + dado3);
Console.WriteLine("Puntaje del Tercer juego:" + (_ = dado1+dado2+dado3));

