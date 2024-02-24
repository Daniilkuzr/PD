using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public List<GameObject> terrainChunks;
    public GameObject player;
    public float checkerRadius;
    Vector3 noTerrainPosition;
    public LayerMask terrainMask;
    public GameObject currentChunk;
    PlayerController pm;

    void Start()
    {
        pm = FindObjectOfType<PlayerController>();
    }


    void Update()
    {
        ChunkCheker();
    }

    void ChunkCheker()
    {
        //if(!currentChunk)
        //{
        //    return;
        //}
        if(pm.moveDir.x>0 && pm.moveDir.y==0 ) //left
        {
            if(!Physics2D.OverlapCircle(player.transform.position + new Vector3(20,0,2),checkerRadius,terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(20, 0, 2);
                SpawnChunk();
            }
        }
        else if(pm.moveDir.x < 0 && pm.moveDir.y == 0) //right
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, 0, 2), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(-20, 0, 2);
                SpawnChunk();
            }
        }
        else if (pm.moveDir.x == 0 && pm.moveDir.y <0) //up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(0, 20, 2), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(-20, 0, 2);
                SpawnChunk();
            }
        }
        else if (pm.moveDir.x == 0 && pm.moveDir.y < 0) //down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(0, -20, 2), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(-20, 0, 2);
                SpawnChunk();
            }
        }
        else if (pm.moveDir.x > 0 && pm.moveDir.y < 0) //left up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, 20, 2), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(20, 0, 2);
                SpawnChunk();
            }
        }
        else if (pm.moveDir.x > 0 && pm.moveDir.y < 0) // left down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, -20, 2), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(20, -20,2);
                SpawnChunk();
            }
        }
        else if (pm.moveDir.x < 0 && pm.moveDir.y > 0) //right up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, 20, 2), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(-20, 20, 2);
                SpawnChunk();
            }
        }
        else if (pm.moveDir.x < 0 && pm.moveDir.y > 0) // right down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, -20, 2), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(-20, -20, 2);
                SpawnChunk();
            }
        }

    }
    void SpawnChunk()
    {
        int rand = Random.Range(0, terrainChunks.Count);
        Instantiate(terrainChunks[rand], noTerrainPosition, Quaternion.identity);
    }
}
