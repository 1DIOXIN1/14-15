using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public Player Player {get; protected set;}

    public abstract void Use();

    public virtual void Initialization(Player player)
    {
        Player = player;
    }

    public virtual void PickUp()
    {
        gameObject.SetActive(false);
    }

    public void PlayParticle()
    {
        
    }

}
