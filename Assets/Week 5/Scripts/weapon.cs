using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public List<Vector2> points;
    Vector2 lastPosition;
    Rigidbody2D rigidbody;
    Vector2 currentPosition;
    public float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(rigidbody.position + (Vector2)transform.up * speed * Time.deltaTime);

        Destroy(gameObject, 10.0f);
    }
}
