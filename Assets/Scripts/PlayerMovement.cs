using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 0f;
    public float sideForce = 0f;
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a")){
            rb.AddForce(-sideForce,0,0);
        }
                if (Input.GetKey("d")){
            rb.AddForce(sideForce,0,0);
        }
    }
}
