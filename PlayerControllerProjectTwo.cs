using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerProjectTwo : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float hRange = 10.0f;
    [SerializeField] GameObject[] projectilePrefab; // Pojectiles List
    float horizontal;

    // crear función para que el jugador se destruya cuando un tag "animal" lo toque
    // private void OnCollisionEnter(Collision other) // Pasa los parametros de collision del obj
    // {
    //     if ( other.transform.tag == "***") // Cuando colisione con un obj "animal" se destruye
    //     {
    //         Death();
    //     }
    // }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            //Shoot food for Pizza
            ShootFood(0);
        }

        if(Input.GetKeyDown(KeyCode.O))
        {
            //Shoot food for another 
            ShootFood(1);
        }

        // Se recibe el input del teclado
        horizontal = Input.GetAxis("Horizontal");

        // Movimiento del player
        transform.Translate(new Vector3(1,0,0) * horizontal * speed * Time.deltaTime);

        // Resrtingir el desplazamiento del player
        if(transform.position.x > hRange)
        {
            transform.position = new Vector3(hRange,transform.position.y,transform.position.z);    
        }

        if(transform.position.x < -hRange)
        {
            transform.position = new Vector3(-hRange,transform.position.y,transform.position.z);
        }
        
    }

    void ShootFood(int index)
    {
        Instantiate(projectilePrefab[index], (transform.position + Vector3.up), transform.rotation);
        // Instantiate a player position, con modificaciones para la posición
    }
}
