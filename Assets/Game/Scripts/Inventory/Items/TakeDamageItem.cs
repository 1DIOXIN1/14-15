using UnityEngine;

public class TakeDamageItem : Item
{
    [SerializeField] private int _damageValue;

    public override void Use() => Player.TakeDamage(_damageValue);
}
