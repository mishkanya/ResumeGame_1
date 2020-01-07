using UnityEngine;
using UnityEngine.Events;

public class CrystalEffects : MonoBehaviour
{ 
    public bool UseLevitationEffect, UseRotationEffect;
    
    [SerializeField] private UnityEvent TakeEffect;
    private float _yPos;
    private bool _moveUp = true;
    private const float _rotationSpeed = 80f;
    private const float _levitationSpeed = 0.5f;
    private const float _deltaYPos = 0.25f;

    private void Start()
    {
        _yPos = transform.localPosition.y;
    }

    private void FixedUpdate()
    {
        if(UseRotationEffect)
            RotationEffect();

        if(UseLevitationEffect)
            LevitationEffect();
    }
    private void RotationEffect(){
        gameObject.transform.rotation = Quaternion.Euler(Time.time * _rotationSpeed, Time.time * _rotationSpeed, Time.time * _rotationSpeed);
    }
    private void destroy() => Destroy(gameObject);
    private void Hider()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        Invoke("destroy",0.5f);
    }

    private void LevitationEffect()
    {
        
        Vector3 VectorToMove = transform.position;
        if(_moveUp)
        {
            VectorToMove.y += _levitationSpeed * Time.deltaTime;
        }
        else
        {
            VectorToMove.y -= _levitationSpeed * Time.deltaTime;
        }
        
        transform.position = VectorToMove;
        if(transform.position.y > _yPos + _deltaYPos || transform.position.y < _yPos - _deltaYPos){
            _moveUp = !_moveUp;
        }
    }
    public void OnPlayerTake(){
        TakeEffect.Invoke();
        Hider();
    }

}
