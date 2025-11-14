using UnityEngine;

public class SpeedBoostItem : Item
{
    [SerializeField] private float _acceleration;

    public override void Use() => Player.ChangeMoveSpeed(_acceleration);
}
