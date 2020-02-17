using UnityEngine;

public class Disease : MonoBehaviour
{
	#region Attribute
	private string name = "";
	private bool unknown, isNeedLab, isNeedIsolation;
	#endregion

	#region Property
	public string Name { get; }
	public bool IsNeedLab { get; }
	public bool Unknown { get; }
	public bool IsNeedIsolation { get; }
	#endregion

	#region Method
	//public string GetColoumn(int index)
	//{
	//	return coloumn[index];
	//}

	public Disease(string[] _coloumn)
	{
		//coloumn = _coloumn;
	}
	#endregion
}
