using System;

class Program
{
    static void Main(string[] args)
    {
        Person fred = new Person("Fred","Flinstone");
        Person steve = new Person("Steve","Minecraft");

        fred.EasternStyleName();
        steve.westernStyleName();
    }
}