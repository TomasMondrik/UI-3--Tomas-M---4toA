using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    // Start is called before the first frame update

   
    public InputField text;

    void Start()
    {

    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        if (text.text == "password")
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}