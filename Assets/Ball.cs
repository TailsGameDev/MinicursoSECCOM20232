using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D.velocity = Vector3.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        speed = -speed;
        rb2D.velocity = Vector3.right * speed;
    }
}
