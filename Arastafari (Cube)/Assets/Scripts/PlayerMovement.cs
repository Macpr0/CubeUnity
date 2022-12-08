using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference the Rigidbody and call it rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float backwardsForce = 1f;

    // Update is called once per frame + Fixed, becaus Physics
    void FixedUpdate()
    {
        // Add a forward force variable
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Adding force to Rigidbody multiplying it by Time for fps

        if (Input.GetKey(KeyCode.D)) // Only executed if condition is met
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);             
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);             
        }
        //if (Input.GetKey("s"))
        //{
        //    rb.AddForce(0, 0, -backwardsForce * Time.deltaTime, ForceMode.VelocityChange);
        //}
        if (rb.position.y < -5f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
