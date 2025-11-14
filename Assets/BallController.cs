using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 direction;
    
    public bool didPlayerScore = false;

    private void Start()
    {
        if (didPlayerScore)
        {
            direction = Vector2.one.normalized;
        }
        else
        {
            direction = -Vector2.one.normalized;
        }
    }

    void FixedUpdate()
    {
     rb.linearVelocity = direction * speed;   
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            direction.y = -direction.y;
        }  else if (other.gameObject.CompareTag("Paddle"))
        {
            direction.x = -direction.x;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Score"))
        {
            GameManager.Instance.ScorePlayer();
            Destroy(gameObject);
        } else if (other.gameObject.CompareTag("ScoreAI"))
        {
            GameManager.Instance.ScoreAI();
            Destroy(gameObject);
        }
        
    }
}
