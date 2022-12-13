using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateAccount : MonoBehaviour
{
    public Button Create;
    public Canvas AccountCreated;
    public Canvas Register;
    public TMPro.TextMeshProUGUI Error;
    //If account is created, flag is true and shows "account created"(canvas)
    private bool flag = false;

    //Codes for checking if entered login was done properly(flag=true)
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
        AccountCreated.gameObject.SetActive(true);
        Register.gameObject.SetActive(false);
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
