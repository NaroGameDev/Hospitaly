using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DataBase : MonoBehaviour
{
	private string[] coloumn;
	public int ColoumnCount { get { return coloumn.Length; } }
	public string GetColoumn(int index)
	{
		return coloumn[index];
	}
	public DataBase(string[] _coloumn)
	{
		coloumn = _coloumn;
	}
}
