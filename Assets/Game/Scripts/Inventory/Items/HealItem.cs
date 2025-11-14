using UnityEngine;

public class HealItem : Item
{
    [SerializeField] private int _healValue;

    [SerializeField] private ParticleSystem _particle;

    public override void Use()
    {
        Player.Heal(_healValue);

        PlayParticle(_particle, Player.transform.position);
    }
}
