using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [SerializeField] float speed = 20f;
    [SerializeField] float turnSpeed = 30f;

    float horizontalInput;
    float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        speed += forwardInput;

        if(speed < 5) speed = 5;

        if(speed > 30) speed = 30;
    
        // transform.Translate(0, 0, 0.2f);
        // Es lo mismo pero escrito de forma simplificada
        
        // transform.Translate(Vector3.forward);
        // Como el objeto va muy rapido se utiliza lo siguiente
        // para normalizar la velocidad del objeto:
        
        // transform.Translate(Vector3.forward * Time.deltaTime);
        // como ahora va muy lento se le agrega otra multiplacion para aumentar la velocidad
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }

    public void Death()
    {
        // Generate Death code
    }
}
