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

public class F_Karabin : Fabryka
{
    public override void Wykonaj(Abstrakcyjny_Rozkaz rozkaz)
    {
        if (this.CzyWokonac(rozkaz))
        {
            if (rozkaz.ID == 4) //Rozkaz produkuj
            {
                R_Produkuj RozkazProdukcji = (R_Produkuj)rozkaz;

                string[] x = RozkazProdukcji.ParametryProduktu.Split('|');

                if (RozkazProdukcji.ParametryProduktu.Split('|')[0] == "karabin") // Rozkaz produkcji karabinu
                {
                    Zasob_wojskowy Wyprodukowany = this.ProdukujKarabin(RozkazProdukcji.ParametryProduktu);
                    rozkaz.Raportuj("Wyprodukowano karabin");

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

        }
        else
        {
            this.NastepnikWykonaj(rozkaz);
        }
    }

    public Zasob_wojskowy ProdukujKarabin(string Parametry_Karabinu)
    {
        return new Karabin();

    }
}

