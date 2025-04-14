using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCtrl : MonoBehaviour
{
    [SerializeField] Transform StartingPlayerPosition;

    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        //Set the player's position
        gameObject.SetActive(false);
        transform.position = StartingPlayerPosition.position;
        transform.rotation = StartingPlayerPosition.rotation;
        gameObject.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnXButton()
    {
        gameManager.XButtonPressed();
    }

    public void OnYButton()
    {
        gameManager.YButtonPressed();
    }

}
