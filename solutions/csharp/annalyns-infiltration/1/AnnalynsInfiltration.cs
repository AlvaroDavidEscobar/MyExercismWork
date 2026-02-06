static class QuestLogic {
    public static bool CanFastAttack(bool knightIsAwake) => knightIsAwake ? false : true;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake ? true : false;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake ? true : false;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) {
        if (archerIsAwake) {
            return false;
        }
        else if (knightIsAwake) {
            if (petDogIsPresent) {
                return true;
            }
            else {
                return false;
            }
        }
        else if (prisonerIsAwake) {
            return true;
        }
        else if (petDogIsPresent) {
            return true;
        }
        else {
            return false;
        }
    }
}
