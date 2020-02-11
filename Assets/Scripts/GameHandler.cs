using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueList
{
    public Vector3 position { get; set; }
    public bool isNull { get; set; }
    public GameObject npcIdentity { get; set; }
}

public class GameHandler : MonoBehaviour
{

    public GameObject cubeRed, cubeGreen;
    IList<QueueList> queuePos = new List<QueueList>()
    {
        // Queue position 1
        new QueueList()
        {
            position = new Vector3(0, 2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue position 2
        new QueueList()
        {
            position = new Vector3(-1, 2),
            isNull = true,
            npcIdentity = null,
        },

        // Queue Position 3
        new QueueList()
        {
            position = new Vector3(-2, 2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 4
        new QueueList()
        {
            position = new Vector3(0, 1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 5
        new QueueList()
        {
            position = new Vector3(-1, 1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 6
        new QueueList()
        {
            position = new Vector3(-2, 1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 7
        new QueueList()
        {
            position = new Vector3(0, -1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 8
        new QueueList()
        {
            position = new Vector3(-1, -1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 9
        new QueueList()
        {
            position = new Vector3(-2, -1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 10
        new QueueList()
        {
            position = new Vector3(-0, -2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 11
        new QueueList()
        {
            position = new Vector3(-1, -2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 12
        new QueueList()
        {
            position = new Vector3(-2, -2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 13
        new QueueList()
        {
            position = new Vector3(-4, 2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 14
        new QueueList()
        {
            position = new Vector3(-5, 2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 15
        new QueueList()
        {
            position = new Vector3(-6, 2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 16
        new QueueList()
        {
            position = new Vector3(-4, 1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 17
        new QueueList()
        {
            position = new Vector3(-5, 1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 18
        new QueueList()
        {
            position = new Vector3(-6, 1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 19
        new QueueList()
        {
            position = new Vector3(-4, -1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 20
        new QueueList()
        {
            position = new Vector3(-5, -1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 21
        new QueueList()
        {
            position = new Vector3(-6, -1),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 22
        new QueueList()
        {
            position = new Vector3(-4, -2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 23
        new QueueList()
        {
            position = new Vector3(-5, -2),
            isNull = true,
            npcIdentity = null,
        },
        // Queue Position 24
        new QueueList()
        {
            position = new Vector3(-6, -2),
            isNull = true,
            npcIdentity = null,
        }
    };
    int currPos = 0;

    // Start is called before the first frame update

    void Start()
    {
        foreach(var pos in queuePos)
        {
            Instantiate(cubeRed, pos.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }

    public void Spawn()
    {
        foreach(var pos in queuePos)
        {
            if (pos.isNull)
            {
                GameObject pasien = Instantiate(cubeGreen, pos.position, Quaternion.identity);
                pos.npcIdentity = pasien;
                pos.isNull = false;
                break;
            }
        }
    }

    public void Call()
    {
        foreach (var pos in queuePos)
        {
            if (!pos.isNull)
            {
                pos.isNull = true;
                Destroy(pos.npcIdentity);
                break;
            }
        }
    }
}
