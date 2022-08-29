using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float startDelay = 3.0f;
    private float spawnInterval = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDog", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    // Spawn dog in play area
    void SpawnDog ()
    {
        // instantiate dog and send
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
