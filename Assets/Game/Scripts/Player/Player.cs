using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class Player : MonoBehaviour
{
    private const string HORIZONTAL_AXIS_NAME = "Horizontal";
    private const string VERTICAL_AXIS_NAME = "Vertical";
    private const KeyCode USE_BUTTON_KEYCODE = KeyCode.F;

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    [SerializeField] private int _startHealth;
    private Health _health;

    private Inventory _inventory;

    private float _deadZone = 0.05f;
    
    private Vector3 _input;
    private Mover _mover;

    private void Awake()
    {
        _mover = new Mover(transform, _moveSpeed, _rotationSpeed);
        _health = new Health(_startHealth);

        _inventory = GetComponent<Inventory>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(USE_BUTTON_KEYCODE))
        {
            _inventory.UseItem(1); //1
        }
        _input = new Vector3(Input.GetAxis(HORIZONTAL_AXIS_NAME), 0, Input.GetAxis(VERTICAL_AXIS_NAME));

        if(_input.magnitude <= _deadZone)
            return;

        _mover.ProcessMoveTo(GetNormalizedDirection());
        _mover.ProcessRotateTo(GetNormalizedDirection());
    }

    public void ChangeMoveSpeed(float value) => _mover.ChangeMoveSpeed(value);

    public void Heal(int value) => _health.Heal(value);

    public void TakeDamage(int value) => _health.TakeDamage(value);

    public Vector3 GetNormalizedDirection() => _input.normalized;
}
