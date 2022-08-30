using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class S1 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset textFile;
    string[] line = new string[7];
    string[] names = {"","เจสัน","ซาร่า"};
    Text textDisplay;
    int currentLine = 0;
    
    void Start()
    {
        string allText = textFile.text;
        line = allText.Split("\n");
        textDisplay = GameObject.Find("Text").GetComponent<Text>();
        textDisplay.text = line[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        currentLine++;
        displayText();
        }
    }
    void displayText()
    {
        string[] tmp = new string[2];
        tmp = line[currentLine].Split(":");
        int cNumber = int.Parse(tmp[0]);
        string txt = "";
        if (cNumber > 0) txt = names[cNumber] + " : " + tmp[1];
        else txt = tmp[1];
        textDisplay.text = txt;

    }
}
