using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnob : MonoBehaviour
{
    [SerializeField]
    private bool locked = true;
    private bool success = false;
    private float successTimer = 0;

    public AudioClip unlockSound;
    public AudioClip successSound;

    private AudioSource audio;

    public bool Locked
    {
        get { return locked; }
        set
        {
            if (!value && locked)
            {
                PlaySound(unlockSound);
            }
            locked = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {}

    void OnTriggerEnter(Collider col)
    {
        if (!locked && col.CompareTag("Little"))
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().NextLevel();
        }
    }

    private void PlaySound(AudioClip sound)
    {
        audio.clip = sound;
        audio.Play();
    }
}