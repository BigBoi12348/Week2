using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }
    public void close()
    {
        Time.timeScale = 1;
        Destroy(ui);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
