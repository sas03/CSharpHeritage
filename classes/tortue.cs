namespace classes;

public class Tortue : Animal{
    public Tortue(string name) : base(name, 4, false){

    }

    public override void Move(){
        Console.WriteLine("Le tortue " + name + " se déplace à " + nombrePattes + " pattes");
    }
}