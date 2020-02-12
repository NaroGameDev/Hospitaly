using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Enumeration
#region Complaints
public enum BodyPartComplaints
{
	HeadComplaints, NoseComplaints, SkinComplaints, EyeComplaints, ThroatComplaints, StomachComplaints, HandComplaints, LegComplaints, ChestComplaints, UrineComplaints, EntireBodyComplaints
}
public enum HeadComplaints
{
	MemoryLoss, Dizzy, Pain
}
public enum NoseComplaints
{
	Itchy, Sneezing, Congestion, Watery
}
public enum SkinComplaints
{
	Red, Pale, Blisters, Rashes, Swelling, Pus
}
public enum EyeComplaints
{
	Red, Swollen, Itchy
}
public enum ThroatComplaints
{
	Hoarse, Itchy, Phlegm
}
public enum StomachComplaints
{
	Nausea, Vomiting, Pain
}
public enum HandComplaints
{
	Cold
}
public enum LegComplaints
{
	Cold
}
public enum ChestComplaints
{
	IrregularHeartbeat, Pain, ShortBreath
}
public enum UrineComplaints
{
	Blood, Turbid
}
public enum EntireBodyComplaints
{
	Sweating, Shivering, Limp, Pain
}
#endregion
public enum Difficult
{
	Mild, Moderate, Severe
}
public enum HealingStage
{
	Check, BloodAnalyst, XRay, Casts, Medication, Therapy, Surgery
}
#endregion


public class Disease : MonoBehaviour
{
	[SerializeField]
	private string Name = "";
	[SerializeField]
	private bool unknown, isNeedLab, isNeedIsolation;
	[SerializeField]
	protected List<BodyPartComplaints> bodyPartComplaints = new List<BodyPartComplaints>();
	[SerializeField]
	protected List<HealingStage> healingStage = new List<HealingStage>();
	[SerializeField]
	private Difficult difficult;
}
