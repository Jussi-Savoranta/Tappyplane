using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 5;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;

        transform.position = new Vector3(transform.position.x, transform.position.y -
            range * Random.value, transform.position.z);
    }
   

    private void OnBecameInvisible()
    {

        Destroy(gameObject);
       
    }
}
