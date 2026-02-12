class RemoteControlCar{

    private int Distance;
    private int Battery = 100;

    public static RemoteControlCar Buy()=> new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {Distance} meters";
    public string BatteryDisplay() => Battery == 0 ? "Battery empty" : $"Battery at {Battery}%";

    public void Drive(){
        if (Battery > 0) {
            Distance = Distance + 20;
            Battery = Battery - 1;
        }
    }
}
