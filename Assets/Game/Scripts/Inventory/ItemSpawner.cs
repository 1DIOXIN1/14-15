using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private Player _player;

    [SerializeField] private List<SpawnPoint> _spawnPositions = new List<SpawnPoint>();

    [SerializeField] private List<Item> _itemPrefabs = new List<Item>();

    private void Start()
    {
        SpawnItems();
    }

    private void SpawnItems()
    {
        int itemCounter = 0;

        foreach (var spawnPoint in _spawnPositions)
        {
            itemCounter++;

            if(itemCounter > _itemPrefabs.Count)
                itemCounter /= _itemPrefabs.Count;
            
            Item item = Instantiate(_itemPrefabs[itemCounter - 1], spawnPoint.Position, Quaternion.identity);
            item.Initialization(_player);
        }
    }
}
