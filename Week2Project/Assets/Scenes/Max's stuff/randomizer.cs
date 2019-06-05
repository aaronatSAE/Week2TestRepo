using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("Hey - this is Max's script. Get out! (Also, Hello world!)");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.rotation = new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0);
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100));
    }
}
