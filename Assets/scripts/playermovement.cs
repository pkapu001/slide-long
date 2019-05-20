using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwordForce = 2000f;

    public float speed = 50f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(transform.position.y < -0.1f)
        {
            FindObjectOfType<gamemanager>().endgame();
        }
           //transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0);
        
    }   

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwordForce * Time.deltaTime);
        if(Input.GetAxis("Horizontal") != 0)
        {
            
            rb.AddForce(speed * Input.GetAxis("Horizontal") * Time.fixedDeltaTime, 0f, 0, ForceMode.VelocityChange);
            
        }
        




    }
}
