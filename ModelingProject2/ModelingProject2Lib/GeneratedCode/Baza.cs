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

public class Baza : Abstrakcyjna_Jednostka
{
	public virtual List<Zasob_wojskowy> ListaZasobow
	{
		get;
		set;
	}

	public virtual string Nazwa_Bazy
	{
		get;
		set;
	}

	public Baza()
	{
	}

	public override void Wykonaj(Abstrakcyjny_Rozkaz rozkaz)
	{
		throw new System.NotImplementedException();
	}

}

