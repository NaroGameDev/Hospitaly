using System.Collections.Generic;
using UnityEngine;

public class WaitingQueue
{
    private List<Vector3> posList;
    private Vector3 entrancePos;
    public GameObject cubeRed, cubeGreen;

    public WaitingQueue(List<Vector3> posList)
    {
        this.posList = posList;
        entrancePos = posList[posList.Count + 1] + new Vector3(-2f, 0);
        foreach (Vector3 pos in posList)
        {
            MonoBehaviour.Instantiate(cubeGreen, pos, Quaternion.identity);
        }
        MonoBehaviour.Instantiate(cubeRed, entrancePos, Quaternion.identity);
    }
}
