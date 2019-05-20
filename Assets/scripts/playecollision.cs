
using UnityEngine;

public class playecollision : MonoBehaviour
{
    public playermovement movement;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {


        if(collision.collider.tag== "Obsticle")
        {
            rb.AddForce(0, 2000f , 0);
            FindObjectOfType<gamemanager>().endgame();
           // movement.enabled = false;
        }
    }


}
