using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject goPlayer;

    Vector3 _cameraOffset; // Var tipo Transform
    // de esta forma _cameraOffset esta indicada como si fuese probada

    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = goPlayer.transform.position + _cameraOffset;
    }
}
