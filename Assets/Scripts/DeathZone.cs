using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider){
        if(collider.tag == "Player")
        {
            SceneObjectContainer.OnSceneReload();
            SceneManager.LoadScene(0);
        }
    }
}
