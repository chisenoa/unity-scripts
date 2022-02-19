using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpAmount;
    private Rigidbody2D rb;

    public float playerAngle;
    Vector3 playerVector;

    private void Start()
    {
        playerAngle = transform.eulerAngles.z;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        playerAngle = transform.eulerAngles.z;

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.up * jumpAmount, ForceMode2D.Impulse);

            if (playerAngle == 0)
                transform.Rotate(0, 0, 90);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-transform.right * jumpAmount, ForceMode2D.Impulse);

            if (playerAngle == 270)
                transform.Rotate(0, 0, 90);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(-transform.up * jumpAmount, ForceMode2D.Impulse);

            if (playerAngle == 180)
                transform.Rotate(0, 0, 90);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(transform.right * jumpAmount, ForceMode2D.Impulse);

            if (playerAngle == 90)
                transform.Rotate(0, 0, 90);
        }
    }
}
