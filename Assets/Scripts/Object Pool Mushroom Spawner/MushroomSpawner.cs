using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField]
    private Mushroom mushroom;
    PoolingSystem pool = new PoolingSystem();
    void FixedUpdate(){
        CreateObject(transform.position);
    }
    public void CreateObject(Vector3 pos)
    {
        pool.CreateObject(mushroom, pos);
    }
}
