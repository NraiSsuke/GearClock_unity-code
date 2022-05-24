using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Minute : MonoBehaviour {

    public GameObject doa;
    Vector3 rot = new Vector3(0, 0, 0);
    bool i = true;
    Vector3 Pos;

	// Use this for initialization
	void Start () {
        rot.z = 0;
        this.transform.eulerAngles = rot;
	}
	
	// Update is called once per frame
	void Update () {
        DateTime d = DateTime.Now;
        int min = d.Minute;

        float w = this.doa.transform.position.x;

        if (Input.GetMouseButton(0)){
            Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if(Input.GetMouseButton(0)){
            if (w >= 8.12f){
                if (i == true)
                {
                    if (rot.z != -(min * 6))
                    {
                            rot.z = rot.z - 0.75f;
                            this.transform.eulerAngles = rot;
                        if (rot.z <= -360)
                        {
                            rot.z = 0;
                        }
                        if (rot.z < (-(min * 6) + 1) && rot.z > (-(min * 6) - 1))
                        {
                            i = false;
                        }
                    }
                }
                if (i == false)
                {
                    setRotation(min);
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
    void setRotation(int min){
        rot.z = -min * (360 / 60);
        this.transform.eulerAngles = rot;
    }
}
