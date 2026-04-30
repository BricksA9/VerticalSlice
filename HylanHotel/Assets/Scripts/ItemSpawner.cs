using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> listOfSpawnLocations;
    [SerializeField] public List<GameObject> listOfSpawnableItems;
    [SerializeField] public int maxSpawnedItems;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetRandomLocation()
    {
        //get a random location and a random item
        GameObject selectedLocation = listOfSpawnLocations[Random.Range(0, listOfSpawnLocations.Count)];
        Debug.Log("got a location: " + selectedLocation);
        return selectedLocation;
    }

    public GameObject GetRandomItem()
    {
        //get a random location and a random item
        GameObject selectedItem = listOfSpawnableItems[Random.Range(0, listOfSpawnableItems.Count)];
        Debug.Log("got an item: " + selectedItem);
        return selectedItem;
    }
}
