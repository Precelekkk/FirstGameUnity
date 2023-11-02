using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Adjust this to control the player's movement speed.
    

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get input from the player.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement vector.
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed;

        // Apply the movement to the player's Rigidbody2D.
        rb.velocity = movement;

        
    }
}