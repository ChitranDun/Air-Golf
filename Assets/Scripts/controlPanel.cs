using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction;


public class controlPanel : MonoBehaviour
{
    public int holeNum = 1;
    public List<int> holeScores = new List<int>();
    public int par = 0;
    public int getPar;
    public int totalPar;
    public float parLength;
    public int shotCount = 0;

    public float toPin;
    public Transform pinPos;
    public Transform bollPos;
    public Transform patPos;
    public int score = 0;

    public int clubID;
    public string clubName;
    public float clubMinPower;
    public float clubMaxPower;

    public float clubPower;

    public GameObject _UI;

    XRHandController HC;

   
    private void Update()
    {
        _uiToggle();
        toPin = Vector3.Distance(patPos.position, pinPos.position)- Vector3.Distance(patPos.position, bollPos.position);
        parLength = Vector3.Distance(patPos.position, pinPos.position);
    }

    public void _driver()
    {
        clubID = 0;
        clubName = "Driver";
        clubMinPower = 190;
        clubMaxPower = 245;
    }
    public void _iron()
    {
        clubID = 1;
        clubName = "Iron";
        clubMinPower = 120;
        clubMaxPower = 190;
    }
    public void _putter()
    {
        clubID = 2;
        clubName = "Putter";
        clubMinPower = 50;
        clubMaxPower = 120;
    }

    public void _uiToggle()
    {
        if (HC._primaryButtonValue == true)
        {
            _UI.SetActive(true);
        }
        else
        {
            _UI.SetActive(false);
        }
    }
}