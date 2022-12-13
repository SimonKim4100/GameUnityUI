using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogIn : MonoBehaviour
{
    public Button Enter;
    public Canvas MainMenu;
    public Canvas LogInPage;
    public TMPro.TextMeshProUGUI Error;
    //If id and password is correct, flag is true and goes on to main menu
    private bool flag = false;

    //Codes for checking if entered login was done properly(flag=true)
    //...
    
    void Start()
    {
        if (flag)
        {
            Enter.onClick.AddListener(Click);
        }
        else{
            Enter.onClick.AddListener(ShowError);
        }
    }
    private void Click()
    {
        MainMenu.gameObject.SetActive(true);
        LogInPage.gameObject.SetActive(false);
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
