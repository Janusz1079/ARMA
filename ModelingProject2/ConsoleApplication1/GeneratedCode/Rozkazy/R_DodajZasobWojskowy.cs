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

public class R_DodajZasobWojskowy : Abstrakcyjny_Rozkaz
{
    public virtual string DocelowaBaza
    {
        get;
        set;
    }

    protected virtual Zasob_wojskowy Zasob_Do_Dodania
    {
        get;
        set;
    }

    public override void Raportuj(string rezultat)
	{
		throw new System.NotImplementedException();
	}

	public R_DodajZasobWojskowy()
	{
        ID = 2;
	}

    public virtual void Dolacz_Zasob(string DocelowaBaza, Zasob_wojskowy Zasob_Do_Dodania)
    {
        this.Zasob_Do_Dodania = Zasob_Do_Dodania;
        this.DocelowaBaza = DocelowaBaza;
    }
}

