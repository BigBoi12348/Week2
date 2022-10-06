using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float bulletVelocity = 5f;
    public GameObject bullet;
    public GameObject bullet1;
    public GameObject wall;
    public GameObject wall1;
    public GameObject armour;
    public float timer;
    public float cooldown = 0.6f;

    
    void Start()
    {

    }

    
    void Update()
    {

        timer -= Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            if(timer <= 0)
            {
                Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 direction = (Vector2)((worldMousePos - transform.position));
                direction.Normalize();
                GameObject bullet = (GameObject)Instantiate(bullet1, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
                timer = cooldown;

                Destroy(bullet, 5);
            }
            
        }
        //if (Input.GetButtonDown("Fire2"))
        //{
        //    Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    var direction = (Vector2)((worldMousePos - transform.position));
        //    var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
     
        //    GameObject wall = (GameObject)Instantiate(wall1, transform.position + (Vector3)(direction * 0.5f), Quaternion.AngleAxis(angle, Vector3.forward));
        //    Debug.Log("Shoot");
        //    Destroy(wall, 3);
        //}

    }

   

}
