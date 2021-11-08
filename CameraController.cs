using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        if (target.position.y >= transform.position.y)
        {
            Vector2 newPos = new Vector2(0, target.position.y);
            transform.position = newPos;
        }
    }
}
