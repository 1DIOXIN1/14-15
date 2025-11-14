using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private MeshRenderer _mesh;
    [SerializeField] private Collider _collider;

    public Player Player {get; protected set;}

    public abstract void Use();

    public virtual void Initialization(Player player)
    {
        Player = player;
    }

    public virtual void PickUp()
    {   
        TurnOfObject();
    }

    public virtual void PlayParticle(ParticleSystem particle, Vector3 position)
    {
        if(particle != null)
        {
            particle.transform.position = position;
            particle.Play();
        }  
    }

    private void TurnOfObject()
    {
        _collider.enabled = false;
        _mesh.enabled = false;
    }

}
