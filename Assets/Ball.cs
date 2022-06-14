using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 force = new Vector3(10, 0, 10);
        //Rigidbody rbody = this.GetComponent<Rigidbody>();
        //rbody.AddForce(force, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        // エンターキーを押したとき
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartBall();
        }

    }

    void StartBall()
    {
        //ボールを0位置に初期化
        this.gameObject.transform.position = new Vector3(0, 0, 0);

        //初期の力を与える
        Vector3 force = new Vector3(10, 0, 10);
        Rigidbody rbody = this.GetComponent<Rigidbody>();
        rbody.velocity = Vector3.zero;
        rbody.AddForce(force, ForceMode.VelocityChange);

    }

}
