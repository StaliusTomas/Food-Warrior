using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
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
}
