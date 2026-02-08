public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber) {
        bool NewYork = phoneNumber.Split("-")[0] == "212";
        bool Fake = phoneNumber.Split("-")[1].Split("-")[0] == "555";
        string Local_Number = phoneNumber.Remove(0, 8);
        return (NewYork, Fake, Local_Number);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
