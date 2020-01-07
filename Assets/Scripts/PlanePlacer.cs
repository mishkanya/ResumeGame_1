using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePlacer : MonoBehaviour
{
    public GameObject[] Crystals;
    private const float _placeHeight = 0.25f;
    private void Start()
    {
        if(Random.value > 0.80f)
        {
            GameObject Crystal = Instantiate(
                Crystals[Random.Range(0,Crystals.Length - 1)],
                new Vector3(transform.position.x,transform.position.y + _placeHeight, transform.position.z),
                transform.rotation
            );
            Crystal.transform.SetParent(transform);
        }
    }
}
