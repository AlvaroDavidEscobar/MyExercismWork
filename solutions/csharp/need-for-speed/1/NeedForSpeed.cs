class RemoteControlCar {
    private int _speed;
    private int _battery_drain;
    private int _battery = 100;
    private int _driven;
    public RemoteControlCar(int speed, int battery_drain) {
        this._speed = speed;
        this._battery_drain = battery_drain;
    }

    public bool BatteryDrained() => _battery < _battery_drain;

    public int DistanceDriven() => _driven;

    public void Drive() {
        if (!BatteryDrained()) {
            _battery = _battery - _battery_drain;
            _driven = _driven + _speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _lenght;
    public RaceTrack(int Lenght) {
        this._lenght = Lenght;
    }

    public bool TryFinishTrack(RemoteControlCar car) {
        while (!car.BatteryDrained()) {
            car.Drive();
            if (car.DistanceDriven() == _lenght) return true;
        }
        return false;
    }
}
