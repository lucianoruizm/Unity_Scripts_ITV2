using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    bool _justHit = false;
    // [SerializeField] float _timer = 1f;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) // Pasa los parametros de collision del obj
    {
        if ( other.transform.tag == "Player") // Cuando se encuentre con un obj "Player" se destruye
        {
            _justHit = true; // El obj al colisionar con Player da true
        }
        if ( other.transform.tag == "Highway" && _justHit) // Cuando sea chocado y caiga en el asfalto se destruye
        {
            Death();// Destruir
        }
    }

    void Death()
    {
        // Destroy(gameObject,_timer); // Detruye el obj en un tiempo determinado
        Destroy(gameObject); // Destruye el obj cuando es colisionado por player y toca el asfalto
    }
}
