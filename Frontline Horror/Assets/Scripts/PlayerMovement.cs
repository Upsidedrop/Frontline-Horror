using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z - 1);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = transform.up * 2;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = -transform.up * 2;
        }
    }
}
