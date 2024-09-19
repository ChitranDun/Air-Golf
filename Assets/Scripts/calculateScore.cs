using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculateScore : MonoBehaviour
{
    controlPanel cp;
    // Start called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _score();
    }

    public void _score()
    {
        cp.getPar += cp.holeScores[cp.holeNum-1];
            cp.totalPar += cp.par;
        cp.score = cp.totalPar - cp.getPar;
    }
}
