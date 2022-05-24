using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switti2 : MonoBehaviour
{
    float rotx, roty;
    Vector3 StartPos;
    Vector3 Pos;
    float nowx;
    float nowy;
    float no1;
    float no2;
    float mousemovex;
    float mousemovey;
    float speed = 0.627f;
    float stop = 1.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        rotx = StartPos.x - Pos.x;
        roty = StartPos.y - Pos.y;

        mousemovex = Input.GetAxis("Mouse X");
        mousemovey = Input.GetAxis("Mouse Y");

        OnMouseDrag();

        if (Input.GetMouseButtonUp(0))
        {
            gameObject.transform.Rotate(0, 0, 0);
        }
    }

    void OnMouseDrag()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        nowx = StartPos.x - Pos.x;
        nowy = StartPos.y - Pos.y;
        if (nowx < 0) nowx = -nowx;
        if (nowy < 0) nowy = -nowy;

        Debug.Log(Pos);

        //回転操作
        if (Input.GetMouseButton(0))
        {
            //通常
            if (Pos.y >= 0)    //半分より上
            {
                gameObject.transform.Rotate(0, 0, mousemovex * speed);
                if (Pos.y < 2)
                {
                    gameObject.transform.Rotate(0, 0, -(mousemovey * speed));
                }
                no1 = Pos.x;
            }
            if (Pos.y <= 0)     //半分より下
            {
                gameObject.transform.Rotate(0, 0, -(mousemovex * speed));
                if (Pos.y > 2)
                {
                    gameObject.transform.Rotate(0, 0, mousemovey * speed);
                }
                no2 = Pos.x;
            }
        }
    }
}