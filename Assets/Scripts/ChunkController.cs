using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkController : MonoBehaviour
{
    public float PlaneSpawnDistance; 
    public GameObject FirstChunk;
    public GameObject[] Chunks;
    private List<GameObject> _sceneChunks = new List<GameObject>();
    private void Start()
    {
        _sceneChunks.Add(FirstChunk);
    }

    private void FixedUpdate()
    {
        if(transform.position.z + PlaneSpawnDistance > _sceneChunks[_sceneChunks.Count - 1].transform.position.z)
        {
            SpawnChunk();
            DeleteChunk();
        }
    }
    private void SpawnChunk()
    {
        GameObject newChanck = Instantiate(Chunks[Random.Range(0,Chunks.Length)]);
        newChanck.transform.position = _sceneChunks[_sceneChunks.Count - 1].transform.Find("ChankEnd").position - newChanck.transform.Find("ChankStart").transform.position;//need make easy spawn system
        _sceneChunks.Add(newChanck);
    } 
    private void DeleteChunk()
    {
        if(_sceneChunks[0].transform.position.z + PlaneSpawnDistance < transform.position.z )
        {
            Destroy(_sceneChunks[0]); //need make destroy effects 
            _sceneChunks.RemoveAt(0);
        }
    } 
    
}
