using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text TxtRoomID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRoomIDText(string s)
    {
        TxtRoomID.text = s;
    }

    public void UnSetRoomIDText(string s)
    {
        if (TxtRoomID.text == s)
        {
            TxtRoomID.text = "";
        }
    }
}
