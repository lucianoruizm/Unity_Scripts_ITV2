using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float animalSpeed = 5.0f;

    void Start()
    {
        Destroy(gameObject,12.0f);
        // Destroy object in ** seconds
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * animalSpeed);
    }
}
