namespace classes;

public class Lezard : Animal{
    public Lezard(string name) : base(name, 4, false){

    }

    public override void Move(){
        Console.WriteLine("Le lezard " + name + " se déplace à " + nombrePattes + " pattes");
    }
}