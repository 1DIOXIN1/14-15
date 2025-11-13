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

        Vector3 input = new Vector3(Input.GetAxis(HORIZONTAL_AXIS_NAME), 0, Input.GetAxis(VERTICAL_AXIS_NAME));

        if(input.magnitude <= _deadZone)
            return;

        Vector3 normalizedInput = input.normalized;

        _mover.ProcessMoveTo(normalizedInput);
        _mover.ProcessRotateTo(normalizedInput);
    }

    public void ChangeMoveSpeed(float value)
    {
        _moveSpeed += value;

        if(_moveSpeed < 0)
            _moveSpeed = 0;
    }

    public void Heal(int value) => _health.Heal(value);

    public void TakeDamage(int value) => _health.TakeDamage(value);
}
