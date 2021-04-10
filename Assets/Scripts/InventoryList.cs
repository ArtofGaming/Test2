using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryList<T> where T : class
{
    private T _item;
    public T item
    {
        get { return _item; }
    }

    public void SetItem(T newItem)
    {
        // 3
        _item = newItem;
        Debug.Log("New item added...");
    }

    public InventoryList()
    {
        Debug.Log("Generic list initalized...");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
