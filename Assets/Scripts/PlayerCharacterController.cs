using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector2 movementDirection = Vector2.zero;
        movementDirection += new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        movementDirection.Normalize();
        rb.velocity = movementDirection * movementSpeed;
    }
    void Update()
    {
        
    }
}
