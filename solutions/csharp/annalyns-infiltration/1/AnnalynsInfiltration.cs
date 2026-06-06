static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
       return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisionerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisionerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisionerIsAwake)
    {
        return !archerIsAwake && prisionerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisionerIsAwake, bool petDogIsPresent)
    {
        bool CanFreeWithDog = petDogIsPresent && !archerIsAwake;
        bool CanFreeWithoutDog = !petDogIsPresent && prisionerIsAwake && !knightIsAwake && !archerIsAwake;
        return CanFreeWithDog || CanFreeWithoutDog;
    }
}
