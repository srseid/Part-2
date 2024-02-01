using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject planes;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(planes);
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            Instantiate(planes);
            time = Random.Range(50, 200);
        }
        else
        {
            time = Time.deltaTime;
        }
    }
}
