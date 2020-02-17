using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingStage : MonoBehaviour
{
	#region Attribute
	//private bool isCheck, isTakeBlood, isXRay, isGypsum, isDrug, isTherapy, isOperation;
	private List<string> stages = new List<string>();
	private List<bool> isNeeded = new List<bool>();
	#endregion

	#region Property
	//public string Check
	//{
	//	get
	//	{
	//		if(isCheck)
	//		{
	//			return "Check";
	//		}
	//		return "";
	//	}
	//}

	//public string Drug
	//{
	//	get
	//	{
	//		if(isDrug)
	//		{
	//			return "Drug";
	//		}
	//		return "";
	//	}
	//}

	//public string Gypsum
	//{
	//	get
	//	{
	//		if (isGypsum)
	//		{
	//			return "Gypsum";
	//		}
	//		return "";
	//	}
	//}

	//public string Operation
	//{
	//	get
	//	{
	//		if (isOperation)
	//		{
	//			return "Operation";
	//		}
	//		return "";
	//	}
	//}

	//public string TakeBlood
	//{
	//	get
	//	{
	//		if (isTakeBlood)
	//		{
	//			return "TakeBlood";
	//		}
	//		return "";
	//	}
	//}

	//public string Therapy
	//{
	//	get
	//	{
	//		if (isTherapy)
	//		{
	//			return "Therapy";
	//		}
	//		return "";
	//	}
	//}

	//public string XRay
	//{
	//	get
	//	{
	//		if (isXRay)
	//		{
	//			return "X-Ray";
	//		}
	//		return "";
	//	}
	//}
	#endregion

	#region Method
	public HealingStage(bool[] stages)
	{
		//isCheck = stages[0];
		//isTakeBlood = stages[1];
		//isXRay = stages[2];
		//isGypsum = stages[3];
		//isDrug = stages[4];
		//isTherapy = stages[5];
		//isOperation = stages[6];
	}

	public string[] GetHealingStage()
	{
		List<string> stages = new List<string>() /*{ Check, Drug, Gypsum, Operation, TakeBlood, Therapy, XRay }*/;
		stages.Remove("");
		//for (int i = 0;i < stages.Count; i++)
		//{
		//	if(stages[i].Equals(""))
		//	{
		//		stages.RemoveAt(i);
		//	}
		//}
		return stages.ToArray();
	}
	#endregion
}
