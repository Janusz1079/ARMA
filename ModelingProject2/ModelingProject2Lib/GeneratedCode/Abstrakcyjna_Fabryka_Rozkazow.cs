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

public class Abstrakcyjna_Fabryka_Rozkazow
{
	public virtual string nazwa_rozkazu
	{
		get;
		set;
	}

	public virtual bool Wydawany_Tylko_Przez_Jednostki
	{
		get;
		set;
	}

	public virtual Abstrakcyjny_Rozkaz TworzRozkaz(string parametr, Centrala info)
	{
		throw new System.NotImplementedException();
	}

	public virtual string PodajFormuleRozkazu()
	{
		throw new System.NotImplementedException();
	}

}

