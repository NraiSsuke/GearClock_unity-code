using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open2 : MonoBehaviour
{
    float rotx, roty;
    Vector3 StartPos;
    Vector3 Pos;
    float nowx;
    float nowy;
    float mousemovex;
    float mousemovey;
    float move;
    bool i = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        rotx = StartPos.x - Pos.x;
        roty = StartPos.y - Pos.y;

        mousemovex = Input.GetAxis("Mouse X");
        mousemovey = Input.GetAxis("Mouse Y");

        OnMouseDrag();
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
        nowx = Pos.x;
        nowy = Pos.y;

        if (Input.GetMouseButtonUp(0))
        {
            i = true;
        }
        if (Input.GetMouseButton(0))
        {
            i = false;
        }
        if (i == false){
            if (nowx > 0)
            {
                move = nowx * 0.01f;
            }
            else
            {
                move = -nowx * 0.01f;
            }
            if (nowx > 1.2)
            {
                move = nowy * 0.01f;
            }
            if (nowx > 1.2 && nowx < 0)
            {
                move = -nowy * 0.01f;
            }
            transform.Translate(move, 0, 0);
        }
    }
}