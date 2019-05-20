using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockspaner : MonoBehaviour
{

    public Transform[] spanpoints;
    public GameObject blockPrefab;
    private float timebetweenspans = 2f;
    private float timetospawn = 2f;


    // Update is called once per frame
    void Update()
    {
       if(Time.time >= timetospawn)
        {
            spawnobject();
            timetospawn = Time.time + timebetweenspans;
        }
    }

    void spawnobject()
    {
        int randumIndex = Random.Range(0, spanpoints.Length);

        for (int i = 0; i < spanpoints.Length; i++)
        {
            if (randumIndex != i)
            {
                Instantiate(blockPrefab, spanpoints[i].position, Quaternion.identity);
            }
        }
    }
}
