using System;

public class Wuerfel
{
    private int seiten;
    private int augenzahl;
    private Random random;

    public Wuerfel(int seiten)
    {
        if (seiten < 1)
            throw new ArgumentException("Ein Würfel muss mindestens eine Seite haben.");

        this.seiten = seiten;
        random = new Random();
        Wuerfeln();
    }

    public int Seiten
    {
        get { return seiten; }
    }

    public int Augenzahl
    {
        get { return augenzahl; }
    }

    public int Wuerfeln()
    {
        augenzahl = random.Next(1, seiten + 1);
        return augenzahl;
    }
}
