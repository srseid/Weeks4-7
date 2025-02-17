using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    //declare prefab gameobject
    //public for inspector
    public GameObject prefab;

    public List<GameObject> createAmmo;
    // Start is called before the first frame update
    void Start()
    {
        createAmmo = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullets = Instantiate(prefab, transform);
            createAmmo.Add(bullets);
            //Instantiate(prefab);
            //Instantiate(prefab, //position//, transform.rotation);
            //makes prefab same rotation as spawner gameobject
            //clone original thing, make the prefab

            Destroy(bullets, 3);
            //destroy prefab in 3 seconds}
        }
        */
        }

    public void Create()
    {
        GameObject bullets = Instantiate(prefab, transform);
        createAmmo.Add(bullets);
        Destroy(bullets, 3);
    }
}
