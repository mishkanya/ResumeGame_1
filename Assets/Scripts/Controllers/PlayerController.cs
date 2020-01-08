using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject _startText;
    private PlayerMove _moveScript;
    private void Start(){
        _startText = SceneObjectContainer.StartText;
        _moveScript = SceneObjectContainer.Player.GetComponent<PlayerMove>();
    }
    private void Update()
    {
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began ) 
            {
                OnTap();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            OnTap();
        }
    }
    private void OnTap(){
        if(_startText != null){
            Destroy(_startText);
        }
       _moveScript.PlayerMoveForvard = !_moveScript.PlayerMoveForvard;
       _moveScript.LvlStarted = true;
    }
}
