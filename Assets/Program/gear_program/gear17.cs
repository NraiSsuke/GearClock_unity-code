using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear17 : MonoBehaviour
{
    Vector3 StartPos;
    Vector3 Pos;
    float nowx, nowy;
    float mousemovex, mousemovey;
    float speed = 2.85f; //

    // Start is called before the first frame update
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

        mousemovex = Input.GetAxis("Mouse X");
        mousemovey = Input.GetAxis("Mouse Y");

        OnMouseDrag();
    }

    void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
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
            if (Pos.y >= 0)
            {
                gameObject.transform.Rotate(0, 0, mousemovex * speed);
                if (Pos.y < 2)
                {
                    gameObject.transform.Rotate(0, 0, -(mousemovey * speed));
                }
            }
            if (Pos.y <= 0)
            {
                gameObject.transform.Rotate(0, 0, -(mousemovex * speed));
                if (Pos.y > 2)
                {
                    gameObject.transform.Rotate(0, 0, mousemovey * speed);
                }
            }
        }
    }
}
