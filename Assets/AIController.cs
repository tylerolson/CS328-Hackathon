using UnityEngine;

public class AIController : MonoBehaviour
{
    
    [SerializeField] private GameObject ball;
    [SerializeField] private float moveSpeed = 3;
    
    [SerializeField] private Rigidbody2D rb;
    
    private Vector2 _aiMoveDirection;
    void Update()
    {
        if (ball == null)
        {
            
            ball = GameObject.FindGameObjectWithTag("Ball"); 
            if (ball == null) return; // Exit if ball still not found
        }

        if (transform.position.y < ball.transform.position.y)
        {
            _aiMoveDirection = Vector2.up.normalized;
            
            // transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            
        }
        else if (transform.position.y > ball.transform.position.y)
        {
            _aiMoveDirection = Vector2.down.normalized;
            
            // transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }
    
    private void FixedUpdate()
    {
        rb.linearVelocity = _aiMoveDirection * moveSpeed;
    }

}
