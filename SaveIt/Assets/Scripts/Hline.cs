using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hline : MonoBehaviour
{

    private Rigidbody2D rb;
    private float speed = 1f;

    private float ymin = -7f;
    private float xmin = -4f;
    private float xmax = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(0, -speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < ymin || transform.position.x > xmax || transform.position.x < xmin)
        {
            Destroy(gameObject);
        }

    }
}
