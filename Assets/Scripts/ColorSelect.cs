using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Dropdown BallColorDropdown;

    public Text ColorText;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChooseColor() // use in the change event for the dropdown
    {
        switch (BallColorDropdown.value)
        {
            case 1:
                ColorText.text = BallColorDropdown.options[1].text;
                Player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                ColorText.text = BallColorDropdown.options[2].text;
                Player.GetComponent<Renderer>().material.color = Color.white;
                break;
            case 3:
                ColorText.text = BallColorDropdown.options[3].text;
                Player.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                ColorText.text = BallColorDropdown.options[0].text;
                Player.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
    

    //}
}