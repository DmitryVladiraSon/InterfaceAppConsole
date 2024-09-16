namespace InterfaceAppConsole.Navigator
{
    internal class WalkerPath : IGetTime
    {
public int GetTime(double kilometers)
{
    return Convert.ToInt32(kilometers / 5);
}
    }
}
