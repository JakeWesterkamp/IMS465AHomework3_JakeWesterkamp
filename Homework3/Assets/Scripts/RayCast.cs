using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField]
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 10f);
            if (hit)
            {
                Destroy(enemy);
                
            }
        }
    }
}
