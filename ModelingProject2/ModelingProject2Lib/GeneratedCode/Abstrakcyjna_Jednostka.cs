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

public class Abstrakcyjna_Jednostka
{
	protected virtual List<int> Lista_Rozkazow
	{
		get;
		set;
	}

	public virtual Abstrakcyjna_Jednostka  nastepnik
	{
		get;
		set;
	}

	public virtual void UstawNastepnik(Abstrakcyjna_Jednostka nastepnik)
	{
		throw new System.NotImplementedException();
	}

	public virtual void CzyWokonac(Abstrakcyjny_Rozkaz rozkaz)
	{
		throw new System.NotImplementedException();
	}

	public virtual void Wykonaj(Abstrakcyjny_Rozkaz rozkaz)
	{
		throw new System.NotImplementedException();
	}

	public Abstrakcyjna_Jednostka()
	{
	}

	protected virtual void NastepnikWykonaj(Abstrakcyjny_Rozkaz rozkaz)
	{
		throw new System.NotImplementedException();
	}

}

