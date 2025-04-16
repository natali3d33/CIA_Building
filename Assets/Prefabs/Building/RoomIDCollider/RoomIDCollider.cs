using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomIDCollider : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        //turn off the renderer (hide the ID collider) on startup
        GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //sets the UI text to the supplied string
        gameManager.SetRoomIDText(name);
    }

    private void OnTriggerExit(Collider other)
    {
        //unset resets the UI text only if it matches the supplied string
        gameManager.UnSetRoomIDText(name);
    }
}
