using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    private Vector3 offset;
    private float speed = 20f;
    private float factor = 1f;

    //private float force = 10f;

    private float ymax = 4f;
    private float ymin = -1.5f;
    private float xmax = 2.5f;
    private float xmin = -2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            offset = transform.position - worldMousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) + offset;

            /*factor = 1/(transform.position - target).magnitude;

            if (factor > 1)
            {
                factor = 1;
            }*/
            
            transform.position = Vector3.Lerp(transform.position, target,speed * Time.deltaTime);
            checkBoundry();
        }

    }
    
    void checkBoundry()
    {
        Vector3 pos = transform.position;

        if (pos.x < xmin)
        {
            pos.x = xmin;
        }else if (pos.x > xmax)
        {
            pos.x = xmax;
        }
        if (pos.y < ymin)
        {
            pos.y = ymin;
        }else if (pos.y > ymax)
        {
            pos.y = ymax;
        }

        transform.position = pos;
    }
/*
    void OnCollisionEnter2D(Collision2D col)
    {
        Vector3 dir = gameObject.GetComponent<Rigidbody2D>().velocity;
        col.gameObject.GetComponent<Rigidbody2D>().AddForce(dir*force);
    }
    */
}
