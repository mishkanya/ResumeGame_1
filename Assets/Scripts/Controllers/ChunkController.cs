using System.Collections.Generic;
using UnityEngine;

public class ChunkController : MonoBehaviour
{
    public float PlaneSpawnDistance, PlaneDestroyDistance; 
    public GameObject FirstChunk;
    public GameObject ChunkPrefub;
    private List<GameObject> _sceneChunks = new List<GameObject>();
    private void Start()
    {
        _sceneChunks.Add(FirstChunk);
    }

    private void FixedUpdate()
    {
        SpawnChunk();
        DeleteChunk();
    }
    private void SpawnChunk()
    {if(SceneObjectContainer.Player.transform.position.z + PlaneSpawnDistance > _sceneChunks[_sceneChunks.Count - 1].transform.position.z)
        {
            Vector3 _lastChunkPosition = _sceneChunks[_sceneChunks.Count - 1].transform.position;
            if(Random.value > 0.5f)
                _lastChunkPosition.x -=2;
            else 
                _lastChunkPosition.z +=2;
            
            GameObject newChanck = Instantiate
            (
                ChunkPrefub,
                _lastChunkPosition,
                _sceneChunks[_sceneChunks.Count - 1].transform.rotation
            );
            _sceneChunks.Add(newChanck);
        }
    } 
    private void DeleteChunk()
    {
        if(_sceneChunks[0].transform.position.z + PlaneDestroyDistance < SceneObjectContainer.Player.transform.position.z )
        {
            Destroy(_sceneChunks[0]); 
            _sceneChunks.RemoveAt(0);
        }
    } 
}
