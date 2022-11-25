using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerProjectTwo : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float hRange = 10.0f;
    [SerializeField] GameObject[] projectilePrefab; // Pojectiles List
    float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // crear función para que el jugador se destruya cuando un tag "animal" lo toque
    // private void OnCollisionEnter(Collision other) // Pasa los parametros de collision del obj
    // {
    //     if ( other.transform.tag == "***") // Cuando colisione con un obj "animal" se destruye
    //     {
    //         Death();
    //     }
    // }

    // Update is called once per frame
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
        // Debug.Log("Var Horizotal = " + horizontal);

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
        // Instantiate to player position, but modifying a little to not appear on the floor

    }
}
