using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

public class DiseaseParser : MonoBehaviour
{
	// Variabel untuk membaca file txt
	private string rootDir = "Assets/";
	public string csvFilesDir = "List Disease/";
	[SerializeField]
  private List<Disease> lines;
	[HideInInspector]
  public int countDialogueLine;

  public void Init()
  {
		csvFilesDir = rootDir + csvFilesDir;
    lines = new List<Disease>();
  }

	#region Get Data Events
	public string GetIndex(int row, int coloumn)
  {
		if(row < lines.Count)
    {
			if(coloumn < lines[row].ColoumnCount)
				return lines[row].GetColoumn(coloumn);
    }
    return "";
  }
	// Mengosongkan Disease
	public void DeleteDiseaseContent()
	{
		if(lines.Count != 0)
		{
			lines.Clear();
		}
	}
	#endregion

	// Membaca File txt
	public void LoadDialogueText(string fileName)
  {
		// Memuat File
		if(File.Exists(csvFilesDir + fileName + ".txt"))
		{
			string file = csvFilesDir + fileName + ".txt";
			string line;
			StreamReader r = new StreamReader(file);
			using (r)
			{
				do
				{
					line = r.ReadLine();
					if (line != null)
					{
						List<string> tempList = new List<string>();
						string[] tempValue = line.Split('"');
						for(int i = 0; i < tempValue.Length; i++)
						{
							if((i % 2) != 0)
							{
								tempList.Add(tempValue[i]);
							}
						}
						string[] lineValue = tempList.ToArray();
						Disease lineEntry = new Disease(lineValue);
						lines.Add(lineEntry);
					}
				} while (line != null);
				r.Close();
			}
			countDialogueLine = lines.Count;
		}
		else
		{
			Debug.Log("File " + fileName + ".txt tidak ditemukan");
		}
  }
}