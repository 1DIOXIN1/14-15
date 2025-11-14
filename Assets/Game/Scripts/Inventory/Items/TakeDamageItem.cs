using UnityEngine;

public class TakeDamageItem : Item
{
    [SerializeField] private int _damageValue;

    [SerializeField] private ParticleSystem _particle;

    public override void Use()
    {
        Player.TakeDamage(_damageValue);

        PlayParticle(_particle, Player.transform.position);
    }
}
