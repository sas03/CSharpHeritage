namespace classes;

public class Elephant : Animal{
    public Elephant(string name) : base(name, 4, false){

    }

    public override void Move(){
        Console.WriteLine("L'elephant " + name + " se déplace à " + nombrePattes + " pattes");
    }
}