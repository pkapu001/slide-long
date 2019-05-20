using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsticle : MonoBehaviour
{
    public Rigidbody rb;
    public float forwordForce = 1100f;
    private float increasedifftimer = 5f;
    private float timetolevelup = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
        if (Time.timeSinceLevelLoad >= timetolevelup)
        {
            forwordForce = forwordForce * (Time.timeSinceLevelLoad / 10);
            timetolevelup = Time.time + increasedifftimer;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z < -2f)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {

        GetComponent<Rigidbody>().AddForce(0, 0, -forwordForce * Time.fixedDeltaTime);
        //Debug.Log(Time.fixedDeltaTime);
        
    }
}
