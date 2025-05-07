using System;
using System.Collections.Generic;

public class Wuerfelbecher
{
    private List<Wuerfel> wuerfelListe;
    private List<bool> festgehalteneWuerfelListe;

    public Wuerfelbecher(int wuerfelAnzahl)
    {
        if (wuerfelAnzahl <= 0)
            throw new ArgumentException("z+Zurzeit existieren keine Würfel. Es muss mindestens 1 Würfel geben!!!.");

        wuerfelListe = new List<Wuerfel>();
        festgehalteneWuerfelListe = new List<bool>();

        for (int i = 0; i < wuerfelAnzahl; i++)
        {
            wuerfelListe.Add(new Wuerfel(6));
            festgehalteneWuerfelListe.Add(false);
        }
    }

    public void Wuerfeln()
    {
        for (int i = 0; i < wuerfelListe.Count; i++)
        {
            if (!festgehalteneWuerfelListe[i])
                wuerfelListe[i].Wuerfeln();
        }
    }

    public void Wuerfelfesthalten(int index, bool festhalten)
    {
        if(index < 0 || index >= festgehalteneWuerfelListe.Count)
            throw new ArgumentException(nameof(index), "ungültiger Würfelindex");

        festgehalteneWuerfelListe[index] = festhalten;
    }
    public List<int> Augenzahl
    {
        get
        {
            List<int> augen = new List<int>();
            foreach(var w in wuerfelListe)
                augen.Add(w.Augenzahl); 
            return augen ;
        }
    }
}

