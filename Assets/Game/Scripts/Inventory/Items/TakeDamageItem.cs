using UnityEngine;

public class TakeDamageItem : Item
{
    [SerializeField] private GameObject _itemPrefab;

    [SerializeField] private int _damageValue;

    public override GameObject ItemPrefab => _itemPrefab;

    public override void Use() => Player.TakeDamage(_damageValue);
}
