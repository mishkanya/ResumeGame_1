using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    [HideInInspector] public bool PlayerMoveForvard = true; 
    private Rigidbody _rigidbody;
    private void Start(){
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _rigidbody.velocity = VectorToMove();
    }
    private Vector3 VectorToMove(){
        Vector3 _moveVector = _rigidbody.velocity;
        _moveVector.y += Physics.gravity.y * _rigidbody.mass;
        if(PlayerMoveForvard == true)
        {
            _moveVector.z += _moveSpeed * Time.fixedDeltaTime;
        }
        else{
            _moveVector.x += _moveSpeed * Time.fixedDeltaTime;
        }
        return _moveVector;
    }
}
