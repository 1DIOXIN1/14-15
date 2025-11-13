using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public Player Player {get; protected set;}

    public abstract GameObject ItemPrefab {get; }

    public abstract void Use();

    public virtual void Initialization(Player player)
    {
        Player = player;
    }

    public virtual void PickUp()
    {
        Destroy(gameObject);
    }

}
