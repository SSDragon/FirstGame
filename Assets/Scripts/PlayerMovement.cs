using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


    void Start()
    {

    }

    void FixedUpdate()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce, 0, 0 * Time.deltaTime);
        }

        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce, 0, 0 * Time.deltaTime);
        }

    }
}
