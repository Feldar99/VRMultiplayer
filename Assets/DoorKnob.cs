using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnob : MonoBehaviour
{
    public bool Locked = true;

    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update() {}

    void OnTriggerEnter(Collider col)
    {
        if (!Locked && col.CompareTag("Little"))
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().NextLevel();
        }
    }
}