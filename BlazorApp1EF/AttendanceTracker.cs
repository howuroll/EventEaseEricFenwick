public class AttendanceTracker
{
    private readonly Dictionary<string, List<string>> Attendance = new();

    public void MarkAttendance(string eventName, string userName)
    {
        if (!Attendance.ContainsKey(eventName))
        {
            Attendance[eventName] = new List<string>();
        }
        Attendance[eventName].Add(userName);
    }

    public List<string> GetAttendees(string eventName)
    {
        return Attendance.ContainsKey(eventName) ? Attendance[eventName] : new List<string>();
    }
}