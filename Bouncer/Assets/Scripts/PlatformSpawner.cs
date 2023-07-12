using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public float timeDelay = 1f;
    private float prevHeight = 0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnPlatform");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnPlatform()
    {
        while (true) {
            GameObject newPlatform = Instantiate(platform, new Vector3(gameObject.transform.position.x, Mathf.Clamp(prevHeight + Random.Range(-2f, 2f), -3.5f, 3.5f), 0), Quaternion.identity);
            prevHeight = newPlatform.transform.position.y;
            newPlatform.transform.localScale = new Vector3(Random.Range(5,10),1,0);
            yield return new WaitForSeconds(timeDelay); ;
        }
        
    }
}
