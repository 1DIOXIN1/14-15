using UnityEngine;

public class SpeedBoostItem : Item
{
    [SerializeField] private float _acceleration;

    [SerializeField] private GameObject _itemPrefab;

    private Player _player;
    
    public override GameObject ItemPrefab => _itemPrefab;

    public override void Use() => _player.ChangeMoveSpeed(_acceleration);
}
