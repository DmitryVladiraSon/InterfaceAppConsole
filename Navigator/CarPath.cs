namespace InterfaceAppConsole.Navigator
{
    internal class CarPath : IGetTime
    {
public int GetTime(double kilometers)
{
    return Convert.ToInt32(kilometers / 60);
}
    }
}
