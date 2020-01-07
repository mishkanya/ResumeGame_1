using UnityEngine;

public class CrystalTake : MonoBehaviour
{
    private void OnTriggerEnter(Collider _collider){
        if(_collider.tag == "Player"){
            GetComponent<CrystalEffects>().OnPlayerTake();
            SceneObjectContainer.PlayerScore = 1;
        }
    }
}
