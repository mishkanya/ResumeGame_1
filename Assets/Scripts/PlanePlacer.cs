using UnityEngine;

public class PlanePlacer : MonoBehaviour
{
    public GameObject[] Crystals;
    private const float _placeHeight = 0.5f;
    private void Start()
    {
        if(Random.value > 0.80f)
        {
            Vector3 PlacePosition = transform.position;
            PlacePosition.y += _placeHeight;
            GameObject Crystal = Instantiate(
                Crystals[Random.Range(0,Crystals.Length - 1)],
                PlacePosition,
                transform.rotation
            );
            Crystal.transform.SetParent(transform.parent);
        }
    }
}
