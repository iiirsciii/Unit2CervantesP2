using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DetectCollisions: MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Check if the Other tag was the player, if it was remove a life
        if (other.CompareTag("Player"))
        {
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
        //Check if the other tag was an Animal, if so add points to the score
        else if (other.CompareTag("Animal"))
        {
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}

