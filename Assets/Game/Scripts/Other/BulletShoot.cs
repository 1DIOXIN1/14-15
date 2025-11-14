using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeBeforeDestroy;

    private Vector3 _direction;

    public void Initialization(Vector3 direction)
    {
        _direction = direction;
    }

    private void Start() => Destroy(gameObject, _timeBeforeDestroy);
    private void Update() => transform.position += _direction * Time.deltaTime * _speed;
}
