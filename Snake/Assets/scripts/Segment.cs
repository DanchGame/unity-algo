using UnityEngine;

// a self-replicating section of a Snake;
public class Segment : MonoBehaviour
{
    static Vector3 direction = Vector2.up;
    public Segment previous;
    public static bool isAlive = true;
    public GameObject sting;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Food")
        {
            Grow();
            Destroy(col.gameObject);
        }
        

    }
    public void Move()
    {

        if(isAlive == false)
        {
            GetComponent<SpriteRenderer>().material.color = Color.red;
            return;
        }
        if(previous == null)
        {
            transform.Translate(direction);
            sting.transform.position = transform.position + direction * 2;
        }
        else
        {
           transform.position = previous.transform.position;
        }
       
    }

    public void Start()
    {
        InvokeRepeating("Move", 0.5f, 0.5f);
    }
    // Snake grows when food is consumed
    public void Grow()
    {
        print("Growing");
        GameObject go = GameObject.Instantiate(gameObject, transform.position + direction, Quaternion.identity);
        Sting script = GetComponentInChildren<Sting>();
        script.Removing();
       
        

        // hook up new segment to a snake "chain"
        previous = go.GetComponent<Segment>();
        
        // ..
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) )
        {
            direction = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow ))
        {
            direction = Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow ) )
        {
            direction = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) )
        {
            direction = Vector3.down;
        }

       
    }
}
