using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        Vector3 force = new Vector3(direction * 1000, 0, 0);
        Rigidbody rbody = this.GetComponent<Rigidbody>();
        rbody.AddForce(force, ForceMode.Impulse);

    }
}
