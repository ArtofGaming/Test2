using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameBehavior gameManager;
    public GameObject peekpickup;
    Material disappear;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("god").GetComponent<GameBehavior>();
        peekpickup = GameObject.Find("Peek Pickup");
    }

    
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            Destroy(peekpickup);
            Debug.Log("Item collected!");
            gameManager.Items += 1;
            gameManager.PrintLootReport();
        }
    }

}
