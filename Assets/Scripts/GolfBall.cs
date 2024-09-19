using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GolfBall : MonoBehaviour
{
    public GameObject _club;
    controlPanel cp;

    private void Start()
    {
        _club.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stick")
        {
            Debug.Log("ok");
            _club.GetComponent<Rigidbody>().isKinematic = false;
            Vector3 bollAngle = _club.GetComponent<Rigidbody>().angularVelocity;
            this.GetComponent<Rigidbody>().AddForce(bollAngle * cp.clubPower, ForceMode.Impulse);
        }
        cp.shotCount += 1;
    }
}
