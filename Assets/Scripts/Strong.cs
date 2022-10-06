using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strong : MonoBehaviour
{
    public GameObject bullet;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        if (name.Equals("shoot"))
        {
            Debug.Log("hit");
            Destroy(enemy);
            Destroy(collision.gameObject);
            
        }
        if (name.Equals("Fast Enemy"))
        {
            Debug.Log("hit");
            Destroy(enemy);
            Destroy(collision.gameObject);
        }
    }
}
