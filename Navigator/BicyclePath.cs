namespace InterfaceAppConsole.Navigator
{
    internal class BicyclePath : IGetTime
    {
public int GetTime(double kilometers)
{
    return Convert.ToInt32(kilometers / 15);
}
    }
}
