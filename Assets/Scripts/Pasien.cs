﻿using UnityEngine;

public class Pasien : MonoBehaviour
{
	[SerializeField]
	private string name = "";
	[SerializeField]
	private int age = 0;
	[SerializeField]
	private Disease disease;
	
	private void Start()
	{
		Debug.Log(DataParser.Instance.CountDataLine);
	}

}
