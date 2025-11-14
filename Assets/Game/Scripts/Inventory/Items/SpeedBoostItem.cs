using UnityEngine;

public class SpeedBoostItem : Item
{
    [SerializeField] private float _acceleration;

    [SerializeField] private ParticleSystem _particle;

    public override void Use()
    {
        Player.ChangeMoveSpeed(_acceleration);
                
        PlayParticle(_particle, Player.transform.position);
    }
}
