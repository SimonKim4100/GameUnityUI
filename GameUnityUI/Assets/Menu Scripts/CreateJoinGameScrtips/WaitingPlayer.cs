using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaitingPlayer : MonoBehaviour
{
    private int count;//player count
    public TMPro.TextMeshProUGUI PlayerCount;
    public Button Back;
    void Start()
    {
        //Player status is changed to stand
        //fetch current connected player list from server
        count = 1;//number of players instead of 1
    }

    
    void Update()
    {
        PlayerCount.SetText("(" + count + "/4 Players)");
        //continue to update count
        CheckStart();
        //Back.onClick.AddListener(x);
        //x: changes player status back to enter and severes connection
    }
    private void CheckStart()
    {
        if(count == 4)
        {
            //player status all changed to ready
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            return;
        }
    }
}
