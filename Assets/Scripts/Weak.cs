using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weak : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.Equals("Player"))
    //    {
    //        Debug.Log("xD");
    //        Destroy(player);
    //        Destroy(collision.gameObject);
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("xD");
            Destroy(player);
            Destroy(collision.gameObject);
        }
    }


}
