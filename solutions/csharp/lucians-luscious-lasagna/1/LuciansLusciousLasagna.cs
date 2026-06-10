class Lasagna
{
    public int ExpectedMinutesInOven()
    {
    return 40;
    } 
    // TODO: define the 'ExpectedMinutesInOven()' method

    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        int remainingMinutes = 40 - actualMinutesInOven;
        return remainingMinutes;
    }
    // TODO: define the 'RemainingMinutesInOven()' method

   public int PreparationTimeInMinutes(int numberOfLayers)  
   {
       int preparationTime = 2 * numberOfLayers;
       return preparationTime;
   }
    // TODO: define the 'PreparationTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int numberLayers,int actualMinutesInOven)
    {
       int preparationTime = numberLayers * 2;
       int elapsedTime = preparationTime + actualMinutesInOven;
        return elapsedTime;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
}
