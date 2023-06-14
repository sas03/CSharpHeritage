namespace classes;

public abstract class Animal{
    protected short nombrePattes;
    protected bool poilu;
    protected string name;

    public Animal(string name, short nombrePattes, bool poilu){
        this.name = name;
        this.poilu = poilu;
        this.nombrePattes = nombrePattes;
    }

    public virtual void Move(){
        Console.WriteLine("Je me déplace à " + nombrePattes + " pattes");
    }
    public void Eat(){
        Console.WriteLine("I'm a " + name + ". So I have a mouth, and can eat");
    }
}