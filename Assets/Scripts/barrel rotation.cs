using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class barrelrotation : MonoBehaviour
{
    public GameObject prefab;
    public bullet spawn;
    public float bulletSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;


        if (spawn == null)
        {
            Spawn();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
            transform.position += transform.up * bulletSpeed * Time.deltaTime;
        }
       
    }

    void Spawn()
    {
        GameObject spawnedBullet = Instantiate(prefab);
        spawn = spawnedBullet.GetComponent<bullet>();
    }

    void Fire()
    {
        spawn.hasBeenFired = true;
        spawn = null;

    }
}
