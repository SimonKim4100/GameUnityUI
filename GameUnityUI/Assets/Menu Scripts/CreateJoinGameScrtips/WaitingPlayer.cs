using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaitingPlayer : MonoBehaviour
{
    private int count;//player count
    private int readycount;//ready player count
    public TMPro.TextMeshProUGUI PlayerCount;
    public Button Back;
    public Button Ready;
    public Button Undo;
    void Start()
    {
        //Player status is changed to stand
        //fetch current connected player list from server
        count = 1;//number of players instead of 1

        Ready.onClick.AddListener(() =>
        {
            Ready.enabled = false;
            Undo.enabled = true;
            //change player status to ready
        });
        Undo.onClick.AddListener(() =>
        {
            Ready.enabled = true;
            Undo.enabled = false;
            //change player status to stand
        });
    }

    
    void Update()
    {
        PlayerCount.SetText("("+readycount+"/"+count + " Players)");
        //continue to update count and readycount
        
        CheckStart();
        //Back.onClick.AddListener(x);
        //x: changes player status back to enter and severes connection
    }
    private void CheckStart()
    {
        if(count == readycount)
        {
            //stop server from accepting more players
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
