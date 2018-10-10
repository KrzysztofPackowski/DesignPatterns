using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    string _buttonText;

    void Start()
    {
        _buttonText = this.transform.GetComponentInChildren<Text>().text.ToString();
    }

    public void TakeAction()
    {
        // Some button specific action
        //...

        Logger.Instance.Log("User clicked " + _buttonText);
    }
}
