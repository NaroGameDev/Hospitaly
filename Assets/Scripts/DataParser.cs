using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class DataParser : MonoBehaviour
{
# region Attribute
	private static string rootDir = "Assets/";
	public static string csvFilesDir = "List Disease/";
	[SerializeField]
  private static List<Disease> listDiseases;
  private int countDataLine;
	private static DataParser instance;
	#endregion

	#region Property
	public static DataParser Instance
	{
		get
		{
			if (instance == null)
			{
				csvFilesDir = rootDir + csvFilesDir;
				listDiseases = new List<Disease>();
				instance = FindObjectOfType<DataParser>();
			}
			return instance;
		}
	}

	public int CountDataLine
	{
		get
		{
			return countDataLine;
		}
	}
	#endregion

	#region Method
	// Mengambil dan memisahkan data Pada File
	public string GetIndex(int row, int coloumn)
  {
		if(row < listDiseases.Count)
    {
			if(coloumn < listDiseases[row].ColoumnCount)
			{
				return listDiseases[row].GetColoumn(coloumn);
			}
    }
    return "";
  }
	// Mengosongkan Disease
	public void DeleteDiseaseContent()
	{
		if(listDiseases.Count != 0)
		{
			listDiseases.Clear();
		}
	}

	// Membaca File txt
	public void LoadDataText(string fileName)
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
						string[] tempValue = line.Split(',');
						for(int i = 0; i < tempValue.Length; i++)
						{
							tempList.Add(tempValue[i]);
						}
						string[] lineValue = tempList.ToArray();
						Disease lineEntry = new Disease(lineValue);
						listDiseases.Add(lineEntry);
					}
				} while (line != null);
				r.Close();
			}
			countDataLine = listDiseases.Count;
		}
		else
		{
			Debug.Log("File " + fileName + ".txt tidak ditemukan");
		}
  }
	#endregion
}