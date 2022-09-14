using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telepathy : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;

    private bool clicked = false;

    private void OnMouseUp()
    {
        clicked = false;
    }
    private void OnMouseDown()
    {
        clicked = true;
    }

    private void Update()
    {
        if (clicked)
        {
            float x = speed * Input.GetAxis("Mouse X");
            float y = speed * Input.GetAxis("Mouse Y");

            transform.transform.position += (Vector3.right * x);
            transform.transform.position += (Vector3.up * y);
        }
    }
}
