using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 0.5f);
    }

    public void Spawn()
    {
        var obj = Instantiate(prefab);
        var pos = new Vector3(Random.Range(-5f, 5f), -5, 0);
        obj.transform.position = pos;
    }

}
