namespace heritage;

using classes;

class Program
{
    static void Main(string[] args)
    {
        Human h = new Human("Steph");
        h.Move();
        h.Eat();

        Singe s = new Singe("Pilaf");
        s.Move();
        s.Eat();

        Elephant e = new Elephant("Garett");
        e.Move();
        e.Eat();

        Tortue t = new Tortue("Ninja");
        t.Move();
        t.Eat();

        Lezard l = new Lezard("Cazaret");
        l.Move();
        l.Eat();
    }
}
