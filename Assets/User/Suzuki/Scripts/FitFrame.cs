using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitFrame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = this.transform.position;
        other.transform.parent = this.transform;
    }

}
