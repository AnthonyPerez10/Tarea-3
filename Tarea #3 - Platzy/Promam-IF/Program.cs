// See https://aka.ms/new-console-template for more information

//Programas de condiciones IF

//ID: 11

int totalJugador = 23;
String message = "";
var totalDealer = 15;
//Juego Blackjack, juntar 21 pidiendo cartas en caso de tener menos

Console.WriteLine("Programa de Mini Juego Blackjack");
Console.WriteLine("Pratica de IF\n\n");

if(totalJugador > totalDealer && totalJugador < 22)
{
    message = "Venciste al Dealer, felicidades";
}
else if (totalJugador > 21)
{
    message = "Perdiste vs Dealer, te pasaste de 21";
}
else if (totalJugador <= totalDealer)
{
    message = "Perdiste vs el Dealer, lo siento";
}
else
{
    message = "Condición no valida";
}

Console.WriteLine("El resultado es: " + message);
