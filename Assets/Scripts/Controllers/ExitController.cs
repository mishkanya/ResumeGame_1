using UnityEngine;

public class ExitController : MonoBehaviour
{
    private bool _quitBool = false;
    private void Update()
    {
        Exit();
    }
    
    private void Exit(){
        if(Input.touchCount > 1)
            _quitBool = false;
            
        if (Input.GetKeyDown(KeyCode.Escape) && _quitBool == true){
            Application.Quit();
        }
        if(Input.anyKey){
            if (Input.GetKey(KeyCode.Escape))
                _quitBool = true;
            else 
                _quitBool = false;
        }
    }
}
