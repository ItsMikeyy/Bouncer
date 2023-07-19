using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public float timeDelay = 1f;
    private bool coroutineStart = false; 
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gm.hasStart && !coroutineStart)
        {
            coroutineStart = true;
            StartCoroutine("SpawnPlatform");

        }
    }

    IEnumerator SpawnPlatform()
    {
        while (true) {
            GameObject newPlatform = Instantiate(platform, new Vector3(gameObject.transform.position.x, Random.Range(-2.5f, 2.5f), 0), Quaternion.identity);
            yield return new WaitForSeconds(timeDelay); ;
        }
        
    }
}
