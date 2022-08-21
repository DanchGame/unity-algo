using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sting : MonoBehaviour
{

    public void Removing()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        print("Collided with: " + col.gameObject);
        if (col.gameObject.tag == "Border")
        {
            Segment.isAlive = false;
            
        }
        if (col.gameObject.tag == "Snake")
        {
            Segment.isAlive = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
