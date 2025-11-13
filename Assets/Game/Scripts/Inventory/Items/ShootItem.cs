using UnityEngine;

public class ShootItem : Item
{
    [SerializeField] private GameObject _itemPrefab;
    [SerializeField] private GameObject _bulletPrefab;

    [SerializeField] private int _startDistanceFromPlayer = 1;
    
    public override GameObject ItemPrefab => _itemPrefab;

    public override void Use()
    {
        Instantiate(_bulletPrefab, Player.transform.position + Vector3.forward * _startDistanceFromPlayer, Quaternion.identity);
    }
}
