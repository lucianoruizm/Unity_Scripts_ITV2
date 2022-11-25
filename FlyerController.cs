using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyerController : MonoBehaviour
{
    [SerializeField] float speed = 30f;
    [SerializeField] float turnSpeed = 10f;

    float verticalInput;
    float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");

        speed += forwardInput;

        if(speed < 5) speed = 5;

        if(speed > 30) speed = 30;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed * verticalInput);
    }
}
