using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JoinGame : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Select;
    public TMPro.TextMeshProUGUI Full;
    public Canvas Join;
    public Canvas Wait;
    public Button JoinBtn;
    public Button Btn1;
    public Button Btn2;
    public Button Btn3;
    public Button Btn4;
    private bool btn1isempty = true;
    private bool btn2isempty = true;
    private bool btn3isempty = true;
    private bool btn4isempty = true;
    private int x=1;//x is number of room we want to enter
    void Start()
    {
        bool isExistsRoom = false;
        //Fetch rooms that are NOT full
        //if room exists, then isExistsRoom = true
        if (btn1isempty && isExistsRoom)
        {
            Btn1.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "";
            //room name in ""
            btn1isempty = false;
        }
        if (btn2isempty && isExistsRoom)
        {
            Btn2.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "";
            //room name in ""
            btn2isempty = false;
        }
        if (btn3isempty && isExistsRoom)
        {
            Btn3.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "";
            //room name in ""
            btn3isempty = false;
        }
        if (btn4isempty && isExistsRoom)
        {
            Btn4.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "";
            //room name in ""
            btn4isempty = false;
        }
        //if a room is selected, it is highlighted and x is changed
        if (!btn1isempty)
        {
            Btn1.onClick.AddListener(() =>
            {
                x = 1;
            });
        }
        if (!btn2isempty)
        {
            Btn2.onClick.AddListener(() =>
            {
                x = 2;
            });
        }
        if (!btn3isempty)
        {
            Btn3.onClick.AddListener(() =>
            {
                x = 3;
            });
        }
        if (!btn4isempty)
        {
            Btn4.onClick.AddListener(() =>
            {
                x = 4;
            });
        }
        JoinBtn.onClick.AddListener(JoinClick);
    }

    void JoinClick()
    {
        if (x != 0 && isRoomFull()) // if room is full, error sign shows
        {
            Select.enabled = false;
            Full.enabled = true;
            Debug.Log("Room is Full");
        }
        else if (x != 0 && !isRoomFull()) // if room is not full, head to waiting screen
        {
            Wait.gameObject.SetActive(true);
            Join.gameObject.SetActive(false);
            Debug.Log("Going to waiting room");
        }

    }

    bool isRoomFull()
    {
        bool full = false;
        //if selected room is full (according to x)
        //then full=true
        return full;
    }
}
