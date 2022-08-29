using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : PoolObject
{
    public float upForce = 1f;
    public float sideForce = .1f;

    public override void OnCreate()
    {
        OnSpawn();
        Invoke("StoreToPool", 3f);
    }
    public override void StoreToPool()
    {
        base.StoreToPool();
    }
    void OnSpawn()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }
}
