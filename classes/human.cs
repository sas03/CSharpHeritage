namespace classes;

public class Human : Animal{
    public Human(string name) : base(name, 2, false){

    }

    public override void Move(){
        Console.WriteLine("Humain bipède " + name + " se déplace à " + nombrePattes + " pattes");
    }
}