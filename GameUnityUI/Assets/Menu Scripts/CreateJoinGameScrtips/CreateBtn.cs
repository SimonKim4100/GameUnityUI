using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateBtn : MonoBehaviour
{
    public Button Create;
    public Canvas CreateMenu;
    public Canvas WaitScreen;
    public TMPro.TextMeshProUGUI Error;
    //If name is not blank
    //and room is successfully registered on server
    //and player status is changed to enter
    //then flag is true
    private bool flag = false;

    //Codes for registering room name on server
    //...
    
    void Start()
    {
        if (flag)
        {
            Create.onClick.AddListener(Click);
        }
        else{
            Create.onClick.AddListener(ShowError);
        }
    }
    private void Click()
    {
        WaitScreen.gameObject.SetActive(true);
        CreateMenu.gameObject.SetActive(false);
    }
    private void ShowError()
    {
        Error.enabled = true;
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        Error.enabled = false;
    }
}
