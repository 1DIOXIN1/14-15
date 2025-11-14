using UnityEngine;

public class ShootItem : Item
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private int _startDistanceFromPlayer = 1;

    [SerializeField] private ParticleSystem _particle;

    public override void Use()
    {
        Instantiate(_bulletPrefab, Player.transform.position + Player.GetNormalizedDirection() * _startDistanceFromPlayer, Quaternion.identity)
        .GetComponent<BulletShoot>()
        .Initialization(Player.GetNormalizedDirection());

        PlayParticle(_particle, Player.transform.position);
    }
}
