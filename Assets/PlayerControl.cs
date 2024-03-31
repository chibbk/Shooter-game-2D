using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    float speed;

    Vector2 dir;

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.up= (Vector2)(Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position);
    }
    private void FixedUpdate()
    {
        rb.velocity = dir * speed;
    }
}

