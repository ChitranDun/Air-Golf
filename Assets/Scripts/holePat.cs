using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holePat : MonoBehaviour
{
    controlPanel cp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cp.holeNum == 1)
        {
            cp.par = 4;
        }
        else if (cp.holeNum == 2)
        {
            cp.par = 5;
        }
        else if (cp.holeNum == 3)
        {
            cp.par = 4;
        }
        else if (cp.holeNum == 4)
        {
            cp.par = 4;
        }
        else if (cp.holeNum == 5)
        {
            cp.par = 3;
        }
        else if (cp.holeNum == 6)
        {
            cp.par = 5;
        }
        else if (cp.holeNum == 7)
        {
            cp.par = 3;
        }
        else if (cp.holeNum == 8)
        {
            cp.par = 4;
        }
        else
        {
            cp.par = 4;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pat")
        {
            cp.holeNum += 1;
            cp.totalPar += cp.par;
            cp.holeScores.Add(cp.shotCount);
            cp.shotCount = 0;
        }
    }
}
