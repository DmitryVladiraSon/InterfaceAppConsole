using InterfaceAppConsole;
using InterfaceAppConsole.Navigator;

Navegator navitator = new Navegator();

double path = 55.4;
Console.WriteLine((navitator.GetNavigate(new CarPath(),path)));
Console.WriteLine((navitator.GetNavigate(new BicyclePath(),path)));
Console.WriteLine((navitator.GetNavigate(new WalkerPath(),path)));


Console.ReadKey();