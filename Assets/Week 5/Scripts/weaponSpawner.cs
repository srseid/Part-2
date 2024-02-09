using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSpawner : MonoBehaviour
{
    public GameObject sword;
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
            timer = Random.Range(1f, 5f);

            GameObject dagger = Instantiate(sword);
            dagger.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);

        }
    }

    public void Spawn()
    {
        GameObject dagger = Instantiate(sword);
        dagger.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);


    }
}
