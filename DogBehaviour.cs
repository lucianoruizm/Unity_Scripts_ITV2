using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
