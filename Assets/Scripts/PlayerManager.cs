using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public bool hasKey = false;
    private GameObject _gate;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered");

        if (other.tag == "Key")
        {
            Debug.Log("Key found");
            hasKey = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "Gate")
        {
            Debug.Log("Near Gate");
            if (hasKey)
            {
                Debug.Log("Open Gate");
                other.gameObject.GetComponent<GateManager>().OpenGate();
                _gate = other.gameObject;
                _gate.gameObject.GetComponent<GateManager>().OpenGate();
                hasKey = false;
            }
        }

    }



}
