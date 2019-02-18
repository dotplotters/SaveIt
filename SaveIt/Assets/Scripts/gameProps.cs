using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameProps : MonoBehaviour
{
    public GameObject Hline;
    private float nextTime = 0f;
    private float spawnRate = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTime)
        {
            Instantiate(Hline);
            nextTime = Time.time + 1 / spawnRate;
        }
    }
}
