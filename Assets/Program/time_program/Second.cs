using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Second : MonoBehaviour
{
    public GameObject doa;
    Vector3 rot = new Vector3(0, 0, 0);
    bool i = true;
    Vector3 Pos;

    // Use this for initialization
    void Start()
    {
        rot.z = 0;
        this.transform.eulerAngles = rot;
    }

    // Update is called once per frame
    void Update()
    {
        DateTime d = DateTime.Now;
        int sec = d.Second;

        float w = this.doa.transform.position.x;

        if (Input.GetMouseButton(0))
        {
            Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            if (w >= 8.12f){
                if (i == true)
                {
                    if (rot.z != -(sec * 6))
                    {
                            rot.z = rot.z - 1.2f;
                            this.transform.eulerAngles = rot;
                        if (rot.z <= -360)
                        {
                            rot.z = 0;
                        }
                        if (rot.z < (-(sec * 6) + 1) && rot.z > (-(sec * 6) - 1))
                        {
                            i = false;
                        }
                    }
                }
                if (i == false)
                {
                    setRotation(sec);
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            i = true;
        }
        if (rot.z <= -360)
        {
            rot.z = 0;
        }
    }
    void setRotation(int sec)
    {
        rot.z = -sec * (360 / 60);
        this.transform.eulerAngles = rot;
    }
}
