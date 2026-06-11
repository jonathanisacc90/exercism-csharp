public static class LineUp
{
    public static string Format(string name, int number)
    {
       int lastTwo = number % 100; //ultimos 2 digitos
        int lastOne = number % 10; // ultimo digito
        string suffix; //Se utilizo un sufijo para que el codigo quede mas limpio
        
        if (lastTwo == 11 || lastTwo == 12 || lastTwo == 13) //casos especiales primero
            suffix = "th"; //utilizacion del sufijo, en vez de repetir return 

        else if (lastOne == 1)
            suffix = "st";
        
        else if (lastOne == 2)
            suffix = "nd";
         
        else if (lastOne == 3)
            suffix = "rd";
          
        else
            suffix = "th";
        
            return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";

    }
}
