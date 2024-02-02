using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class another : MonoBehaviour
{
    public GameObject planes;
    public Sprite[] sprites;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = Random.Range(1,5);

            GameObject plane = Instantiate(planes);
            plane.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
            plane.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360f));

            plane.GetComponent<plane>().speed = Random.Range(1f, 3f);
            plane.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
        }
       
    }
}
