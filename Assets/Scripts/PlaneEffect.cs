using UnityEngine;

public class PlaneEffect : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Color _color;
    private MeshRenderer _render;
    private const float _speedOfAlphaChange = 0.8f;
    private void Start(){
        _rigidbody = GetComponent<Rigidbody>();
        _render = GetComponent<MeshRenderer>();
        _color = _render.material.GetColor("_Color");
    }

    private void OnTriggerExit(Collider collider)
    {
        if(collider.tag == "Player")
        {
            _rigidbody.isKinematic = false;
            _rigidbody.useGravity = true;
        }
    }
    private void FixedUpdate(){
        if(_color.a < 0.99f)
        _color.a += Time.fixedDeltaTime * _speedOfAlphaChange;
        _render.material.SetColor("_Color", _color);
    }
}
