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

public class R_Produkuj : Abstrakcyjny_Rozkaz
{
	public virtual string ParametryProduktu
	{
		get;
		set;
	}

	public virtual string DocelowaBaza
	{
		get;
		set;
	}

	public R_Produkuj(Action<string> Callback)
	{
	}

	public virtual void Ustaw_Parametry_Rozkazu(string ParametryProduktu, string DocelowaBaza, Action<Abstrakcyjny_Rozkaz> CentralaZlecWykonanieRozkazu, Func<string , object > CentralaWytworzRozkaz)
	{
		throw new System.NotImplementedException();
	}

}

