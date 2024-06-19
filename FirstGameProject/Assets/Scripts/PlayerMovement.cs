using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 500f;  // jumpforce
    public float fallMultiplier = 2.5f; // fallforce

    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Yanlara hareket
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

        // Düþme hýzýný artýr
        if (rb.velocity.y < 0 && !isGrounded)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("JumpTrigger"))  // JumpTrigger collide check
        {
            Debug.Log("JumpTrigger detected");  // Debug message
            Jump();
        }

        if (other.CompareTag("Collectible"))  // Collectible collide check
        {
            Debug.Log("Collectible detected");  // Debug message
            FindObjectOfType<Score>().Collect(other.gameObject); // Score update
        }
    }

    void Jump()
    {
        Debug.Log("Jumping");  // Debug message
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);  // JumpForce
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // When we touch the Ground, isGrounded value true.
            // Remove fallMultiplier force
            rb.velocity -= Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("JumpTrigger")) // JumpTrigger exit check
        {
            Debug.Log("Exited JumpTrigger"); // Debug messsage
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; // When we don't touch the Ground, isGrounded value false.
        }
    }
}
