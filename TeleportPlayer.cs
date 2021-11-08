using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = new Vector2(-collision.gameObject.transform.position.x, collision.gameObject.transform.position.y);

    }
}
