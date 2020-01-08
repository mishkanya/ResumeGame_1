using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    [HideInInspector] public bool PlayerMoveForvard = true, LvlStarted = false; 
    private Rigidbody _rigidbody;
    private void Start(){
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(LvlStarted == true)
            _rigidbody.velocity = VectorToMove();
    }
    private Vector3 VectorToMove(){
        Vector3 _moveVector = _rigidbody.velocity;
        _moveVector.y += Physics.gravity.y * _rigidbody.mass;
        if(PlayerMoveForvard == true)
        {   _moveVector.x = 0;
            _moveVector.z = _moveSpeed * Time.fixedDeltaTime;
        }
        else{
            _moveVector.z = 0;
            _moveVector.x = -_moveSpeed * Time.fixedDeltaTime;
        }
        return _moveVector;
    }
}
