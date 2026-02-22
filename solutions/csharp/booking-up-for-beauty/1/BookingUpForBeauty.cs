using System.Diagnostics;

static class Appointment {
    public static DateTime Schedule(string appointment_date_description) => DateTime.Parse(appointment_date_description);

    public static bool HasPassed(DateTime appointment_date) => appointment_date < DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointment_date) => 12 <= appointment_date.Hour && appointment_date.Hour < 18;

    public static string Description(DateTime appointment_date) => $"You have an appointment on {appointment_date}.";

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15);
}
