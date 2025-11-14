using UnityEngine;

public class HealItem : Item
{
    [SerializeField] private int _healValue;

    public override void Use() => Player.Heal(_healValue);
}
