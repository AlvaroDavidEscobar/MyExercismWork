class RemoteControlCar{

    private int Distance;
    private int Battery = 100;

    public static RemoteControlCar Buy(){
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay() => $"Driven {Distance} meters";

    public string BatteryDisplay() => Battery == 0 ? "Battery empty" : $"Battery at {Battery}%";

    public void Drive(){
        if (Battery > 0) {
            Distance = Distance + 20;
            Battery = Battery - 1;
        }
    }
}
