using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropRandomizer : MonoBehaviour
{
    public List<GameObject> propSpawnPoints;
    public List<GameObject> propPreFabs;
    void Start()
    {
        SpawnProps();
    }

    
    void Update()
    {
         
    }

    void SpawnProps()
    {
        foreach (GameObject sp in propSpawnPoints)
        {
            int rand = Random.Range(0, propPreFabs.Count);
           GameObject prop= Instantiate(propPreFabs[rand], sp.transform.position, Quaternion.identity) ;
            prop.transform.parent = sp.transform;
        }
    }
}
