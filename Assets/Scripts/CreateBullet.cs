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
        //put clones in list
        createAmmo = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        }

    public void Create()
    {
        //launch bullet when pressing create button
        GameObject bullets = Instantiate(prefab, transform);
        //make
        createAmmo.Add(bullets);
        //add to list
        Destroy(bullets, 5);
        //destroy after 5 seconds
    }
}
