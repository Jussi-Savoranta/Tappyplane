using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject rock;
    public Transform rockSpot;
    public bool spawned;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rock"))
        {
            StartCoroutine(SpawnRock());
        }
    }
    IEnumerator SpawnRock()
    {
       // while (!spawned)
        //{
            yield return new WaitForEndOfFrame();
            GameObject rockclone = Instantiate(rock, rockSpot.position, rockSpot.rotation);
            //
       // }
    }
}
