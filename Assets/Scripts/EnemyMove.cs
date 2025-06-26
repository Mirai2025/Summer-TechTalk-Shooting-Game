using UnityEngine;

public class enemyMove_Toku : MonoBehaviour
{
    public float speed = 5.0f;

    Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody2D>();
    }

    public void Move()
    {
        Vector2 moveDirection = new Vector2(0, -1);
        Vector2 moveVector = moveDirection * speed;
        _rigidbody.linearVelocity = moveVector;
    }
}