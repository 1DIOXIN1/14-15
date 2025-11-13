using UnityEngine;

public class HealItem : Item
{
    [SerializeField] private GameObject _itemPrefab;

    [SerializeField] private int _healValue;

    public override GameObject ItemPrefab => _itemPrefab;

    public override void Use() => Player.Heal(_healValue);
}
