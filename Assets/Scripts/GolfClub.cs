using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfClub : MonoBehaviour
{
    controlPanel cp;
   
    public void resetClub()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(1).gameObject.SetActive(false);
        this.transform.GetChild(2).gameObject.SetActive(false);
        changeClub();
    }
    void changeClub()
    {
        this.transform.GetChild(cp.clubID).gameObject.SetActive(true);
    }
}
