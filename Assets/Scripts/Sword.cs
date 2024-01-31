using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            var pos = Input.mousePosition;
            var worldPos = Camera.main.ScreenToWorldPoint(pos);
            worldPos.z = 0;


            transform.position = worldPos;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
