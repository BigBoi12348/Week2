using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strong : MonoBehaviour
{
    public GameObject bullet;
    public GameObject enemy;
    public GameObject player;
    private GameManager gameManager;
    
        // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (name.Equals("Gbox"))
        {
            Debug.Log("hit");
            Destroy(enemy);
            Destroy(collision.gameObject);
            gameManager.CheckForEnemys();
        }
        if (name.Equals("shoot"))
        {
            Debug.Log("hit");
            Destroy(enemy);
            Destroy(collision.gameObject);
            gameManager.CheckForEnemys();
        }
        if (name.Equals("Fast Enemy"))
        {
            Debug.Log("hit");
            Destroy(enemy);
            Destroy(collision.gameObject);
            gameManager.CheckForEnemys();
        }
        //if (name.Equals("Player"))
        //{
        //    Debug.Log("xD");
        //    Destroy(player);
        //    Destroy(collision.gameObject);
        //    gameManager.CheckForEnemys();
        //}
        
    }
}
