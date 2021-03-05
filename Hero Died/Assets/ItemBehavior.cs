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
        disappear = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            if (gameObject == peekpickup)
            {
                disappear.color = Color.red;
            }

            Destroy(this.transform.gameObject);
            
            Debug.Log("Item collected!");
            gameManager.Items += 1;
        }
    }

}
