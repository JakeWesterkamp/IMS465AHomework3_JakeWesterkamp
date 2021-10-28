using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Platform")
        {
            Destroy(col.gameObject);
        }
        
    }
}
