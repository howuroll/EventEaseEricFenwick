public class StateContainer
{
    public string? UserName { get; private set; }

    public void SetUserName(string userName)
    {
        UserName = userName;
    }

    public void ClearSession()
    {
        UserName = null;
    }
}