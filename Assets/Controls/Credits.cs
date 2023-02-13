using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Credits : MonoBehaviour
{
    GameObject testField;
    TMP_Text text;
    bool opened;
    bool creditsOpened = false;
    bool controlsOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        testField = GameObject.Find("TextField");
        opened = false;
        testField.SetActive(opened);
        text = testField.transform.GetChild(0).GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCredits(){
        if (opened){
            if (creditsOpened){
                opened = false;
                testField.SetActive(false);
                creditsOpened = false;
            }
            else{
                SetCredit();
                creditsOpened = true;
                controlsOpened = false;
            }
        }
        else{
            opened = true;
            testField.SetActive(true);
            SetCredit();
            creditsOpened = true;
            controlsOpened = false;
        }
        
    }

    public void OpenControls(){
        if (opened){
            if (controlsOpened){
                opened = false;
                testField.SetActive(false);
                controlsOpened = false;
            }
            else{
                SetControls();
                controlsOpened = true;
                creditsOpened = false;
            }
        }
        else{
            opened = true;
            testField.SetActive(true);
            SetControls();
            controlsOpened = true;
            creditsOpened = false;
        }
    }


    // TODO Change Strings
    public void SetCredit(){
        text.text = "CREDIT";
    }
    public void SetControls(){
        text.text = "Jump: Z / Left Mouse\nShoot: X / Mouse Right\n    (Need a disc)";
    }
    public void Close(){
        opened = false;
        testField.SetActive(opened);
    }
}
