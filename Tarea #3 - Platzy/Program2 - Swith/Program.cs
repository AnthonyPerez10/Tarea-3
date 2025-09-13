// See https://aka.ms/new-console-template for more information

//Control de de Switch 

//ID: 11

int totalJugador = 23;
String message = "";
var totalDealer = 15;
String SwitchControl = "21";

//Juego Blackjack, juntar 21 pidiendo cartas en caso de tener menos
switch(SwitchControl)
{
    case "Menu":
        Console.WriteLine("Bienvenido al casino");
        Console.WriteLine("Escriba 21, para jugar 21");
        SwitchControl = Console.ReadLine();
        break;
    case "21":
        if (totalJugador > totalDealer && totalJugador < 22)
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
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}