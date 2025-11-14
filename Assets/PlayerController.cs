using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public static PlayerController Instance;
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    private Vector2 _playerMoveDirection;
    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        var inputY = Input.GetAxisRaw("Vertical");
        _playerMoveDirection = new Vector2(0, inputY).normalized;
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = _playerMoveDirection * moveSpeed;
    }
}
