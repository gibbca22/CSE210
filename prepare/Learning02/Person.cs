using System;

class Person{

    public string givenName;

    public string familyName;

    public Person() {

    }

    public void EasternStyleName() {
        Console.WriteLine($"{this.familyName}, {this.givenName}");
    }

    public void westernStyleName() {
        Console.WriteLine($"{this.familyName}, {this.givenName}");
    }
    
}