﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class P_Zolnierz : Poligon
{
    public override void Wykonaj(Abstrakcyjny_Rozkaz rozkaz)
    {
        if (this.CzyWokonac(rozkaz))
        {
            if (rozkaz.ID == 3) //Rozkaz mobilizacji
            {
                R_Mobilizacja RozkazProdukcji = (R_Mobilizacja)rozkaz;

                string[] x = RozkazProdukcji.ParametryProduktu.Split('|');

                if (RozkazProdukcji.ParametryProduktu.Split('|')[0] == "zolnierz") // Rozkaz mobilizacji zolnierza
                {
                    Zasob_wojskowy Wyprodukowany = this.MobilizujZolnierza(RozkazProdukcji.ParametryProduktu);
                    rozkaz.Raportuj("Wyszkolono Zolnierza");

                    Abstrakcyjny_Rozkaz RozkazDodania = RozkazProdukcji.CentralaWytworzRozkaz("dodajzasob");
                    R_DodajZasobWojskowy RozkazDodaniaZrzutowany = (R_DodajZasobWojskowy)RozkazDodania;
                    RozkazDodaniaZrzutowany.Dolacz_Zasob(RozkazProdukcji.DocelowaBaza, Wyprodukowany);
                    RozkazProdukcji.CentralaZlecWykonanieRozkazu((Abstrakcyjny_Rozkaz)RozkazDodaniaZrzutowany);
                }
                else
                {
                    this.NastepnikWykonaj(rozkaz);
                }
            }
            if (rozkaz.ID == 5) //Rozkaz zamelduj
            {
                rozkaz.Raportuj("Poligon Zolnierzy, zglasza gotowosc");
                this.NastepnikWykonaj(rozkaz);
            }

        }
        else
        {
            this.NastepnikWykonaj(rozkaz);
        }
    }

    protected Zasob_wojskowy MobilizujZolnierza(string Parametry_Zolnierza)
    {
        return new Zolnierz();
    }
}

