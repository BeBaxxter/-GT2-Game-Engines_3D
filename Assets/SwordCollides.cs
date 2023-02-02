using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollides : MonoBehaviour
{
    private SoundEffectsManager _soundEffectsManager;

    private void Start()
    {
        _soundEffectsManager = FindObjectOfType<SoundEffectsManager>();
    }

    public void playSlashSound1()
    {
        _soundEffectsManager.playSoundEffect(3);
    }
    
    public void playSlashSound2()
    {
        _soundEffectsManager.playSoundEffect(5);
    }
}
