using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    [SerializeField] int damageAmmount = 10;

    [SerializeField] GameObject explotion;

    [SerializeField] AudioSource asExplotionSound;
    [SerializeField] AudioClip explotionSound;

    GameObject gameManager;

    GameController gameController;

    void  Start() 
    {
        Destroy(gameObject,3.0f);

        gameManager = GameObject.Find("GameController");

        if(gameManager == null) Debug.Log("GameManager Object not found");

        gameController = gameManager.GetComponent<GameController>();

        if(gameController == null) Debug.Log("GameController Script not found");
   }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //On collision destroy the object
        if(other.gameObject.CompareTag("Animals"))
        {   
            // Score
            gameController.ScoreUp(damageAmmount);
            
            // Explotion
            Instantiate(explotion, other.gameObject.transform.position, other.gameObject.transform.rotation);
            
            // Sound
            asExplotionSound.PlayOneShot(explotionSound);
            
            // Destroy the animal
            Destroy(other.gameObject);

            // Destroy the food
            Destroy(gameObject, 2.0f);
        }
    }
}
