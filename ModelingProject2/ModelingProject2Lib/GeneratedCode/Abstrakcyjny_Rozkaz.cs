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

public class Abstrakcyjny_Rozkaz
{
	protected virtual Action<string> Callback
	{
		get;
		set;
	}

	public virtual int ID
	{
		get;
		set;
	}

	public virtual void Raportuj(string rezultat)
	{
		throw new System.NotImplementedException();
	}

}
