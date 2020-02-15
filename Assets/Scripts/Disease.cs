public class Disease
{
	#region Attribute
	private string name = "";
	private bool unknown, isNeedLab, isNeedIsolation;
	private string[] coloumn;
	#endregion

	#region Property
	public string Name { get; }
	public bool IsNeedLab { get; }
	public bool Unknown { get; }
	public bool IsNeedIsolation { get; }
	public int ColoumnCount { get { return coloumn.Length; } }
	#endregion

	#region Method
	public string GetColoumn(int index)
	{
		return coloumn[index];
	}

	public Disease(string[] _coloumn)
	{
		coloumn = _coloumn;
	}
	#endregion
}
