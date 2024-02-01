using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class another : MonoBehaviour
{
    public GameObject planes;
    float time;
    float speed = 5f;
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
            time = Random.Range(50, 70);
        }
        else
        {
            time = Time.deltaTime;
        }
    }
}
