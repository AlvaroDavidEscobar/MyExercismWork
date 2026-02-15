using System.Runtime.CompilerServices;

class BirdCount {
    private int[] _birds_per_day;
    private static int[] _last_week = new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public BirdCount(int[] birds_per_day) {
        _birds_per_day = birds_per_day;
    }

    public static int[] LastWeek() => _last_week;

    public int Today() => _birds_per_day[6];

    public void IncrementTodaysCount() {
        _birds_per_day[6]++;
    }

    public bool HasDayWithoutBirds() {
        bool day_without_birds = false;
        foreach (int birds in _birds_per_day) {
            if (birds == 0) {
                day_without_birds = true;
            }
        }
        return day_without_birds;
    }

    public int CountForFirstDays(int number_of_days) {
        int result = 0;
        for (int i = 0; i < number_of_days; i++) {
            result += _birds_per_day[i];
        }
        return result;
    }

    public int BusyDays() {
        int busy_days = 0;
        foreach (var birds in _birds_per_day) {
            if (birds >= 5) busy_days++;
        }
        return busy_days;
    }
}
