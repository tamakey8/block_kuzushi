using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject PreBlock;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 pos = new Vector3(-5, 1, 8);
        //Instantiate(PreBlock, pos, Quaternion.identity);

        //pos = new Vector3(0, 1, 8);
        //Instantiate(PreBlock, pos, Quaternion.identity);

        //pos = new Vector3(5, 1, 8);
        //Instantiate(PreBlock, pos, Quaternion.identity);

        for (float x = -5; x<= 5; x += 5)
        {
            for (float z = 2; z <= 8; z += 3)
            {
                Vector3 pos = new Vector3(x, 1, z);
                Instantiate(PreBlock, pos, Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
