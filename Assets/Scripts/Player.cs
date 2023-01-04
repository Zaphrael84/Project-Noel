using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
private Vector2 target;



    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousePos.x, mousePos.y);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);
    }
}
