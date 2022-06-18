using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    GameObject image_game_clear;
    // Start is called before the first frame update
    void Start()
    {
        image_game_clear = GameObject.Find("ImageGameClear");
    }

    // Update is called once per frame
    void Update()
    {
        if (image_game_clear.activeSelf)
        {
            image_game_clear.SetActive(false);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Blocks");
        if (blocks.Length == 1)
        {
            image_game_clear.SetActive(true);
        }
        Destroy(this.gameObject);

    }

}
