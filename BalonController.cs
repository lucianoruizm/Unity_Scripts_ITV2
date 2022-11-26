using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonController : MonoBehaviour
{
    [SerializeField] float _speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.transform.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
