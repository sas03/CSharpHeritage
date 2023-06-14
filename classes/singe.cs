namespace classes;

public class Singe : Animal{
    public Singe(string name) : base(name, 2, true){

    }

    public override void Move(){
        Console.WriteLine("Le Singe " + name + " se déplace à " + nombrePattes + " pattes");
    }
}