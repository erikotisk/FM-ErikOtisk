using System;
using System.Runtime.CompilerServices;

class Program{

    public static void Main(string[] args){
        Zvire Kocka = new Zvire("Meow", "Bermska", 4);

        Zvire Hlemyzd = new Zvire("plaz plaz", "Zahradni", 1);

        Zvire Moucha = new Zvire("bzzz", "Otravna", 2);

        Zvire Komar = new Zvire("(otravne) bzzz", "Savej", 1);

        Zvire Krecek = new Zvire("Pisk", "Sedy", 3);

        Zvire Medved = new Zvire("Brum brum", "Lesni", 5);

        Zvire Krtek = new Zvire("Hrab Hrab", "Cerny", 2);

        Zvire Kocka2 = new Zvire("Mnau", "Britska", 3);

        Zvire Kocka3 = new Zvire("Mnau", "Siamska", 10);

        Zvire Kocka4 = new Zvire("Mnau", "Habesska", 5);

        Zvire Kocka5 = new Zvire("Mnau", "Sphynx", 2);
        Zvire.print(Kocka);
        Zvire.print(Hlemyzd);
        Zvire.print(Moucha);
        Zvire.print(Komar);
        Zvire.print(Krecek);
        Zvire.print(Medved);
        Zvire.print(Krtek);
        Zvire.print(Kocka2);
        Zvire.print(Kocka3);
        Zvire.print(Kocka4);
        Zvire.print(Kocka5);
    }
}

class Zvire{
    private string zvuk;

    private string rasa;

    private int vek;

    public Zvire(string zvuk, string rasa, int vek){
        this.zvuk = zvuk;
        this.rasa = rasa;
        this.vek = vek;
    }

    public static void print(Zvire zvire){
        Console.WriteLine("Rasa = " + zvire.rasa);
        Console.WriteLine("Zvuk = " + zvire.zvuk);
        Console.WriteLine("Vek = " + zvire.vek);
    }
}