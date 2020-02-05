using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float oldTime = 0;
    private bool firstTime = true;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)  && (((Time.time - oldTime) >= .5f) || firstTime))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            oldTime = Time.time;
            firstTime = false;
        }
    }
}
