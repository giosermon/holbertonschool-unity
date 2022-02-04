using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to handle main Camera
/// </summary>
public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = player.position + offset;

    } 
}
