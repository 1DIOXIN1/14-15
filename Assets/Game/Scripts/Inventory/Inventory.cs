using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private int _maxCountItems = 1;

    private List<Item> _items = new List<Item>();

    private void OnTriggerEnter(Collider other) 
    {
        Item item = other.GetComponent<Item>();

        if(item != null && HasEmptySlot())
            AddItem(item);
    }

    public void UseItem(int slotsNumber)
    {
        int index = slotsNumber - 1;

        if(index < 0 || index >= _items.Count || _items[index] == null)
        {
            Debug.Log("Нет предмета");
            return;
        }

        _items[index].Use();
        _items.RemoveAt(index);
    }

    private void AddItem(Item item)
    {
        _items.Add(item);
        item.PickUp(); 
    }

    private bool HasEmptySlot() => _items.Count < _maxCountItems;
}
