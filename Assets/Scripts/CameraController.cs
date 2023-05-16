using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform objectToFollow;

    void FixedUpdate()
    {
        Vector3 romptic = objectToFollow.position + new Vector3(0,0,-10);
        transform.position = Vector3.Lerp(transform.position, romptic, 0.1f);
    }
}
