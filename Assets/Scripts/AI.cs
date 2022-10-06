using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float bulletVelocity = 5f;
    public GameObject bullet;
    public GameObject bullet1;
    public GameObject player;
    public float timer;
    public float colldown = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer <= 0)
        {
            Vector2 direction = (Vector2)((player.transform.position - transform.position));
            direction.Normalize();
            GameObject bullet = (GameObject)Instantiate(bullet1, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
            timer = colldown;
            
        }    
        timer -= Time.deltaTime;

       
    }



   
}
