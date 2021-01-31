using System.Collections;
using System.Collections.Generic;
using Doozy.Engine.Soundy;
using UnityEngine;

public class AudioManager_Baby : AudioManager{

    [SerializeField] public List<AudioClip> complaints_short;
    [SerializeField] public List<AudioClip> complaints_long;
    [SerializeField] public List<AudioClip> grunt;
    [SerializeField] public List<AudioClip> happy;
    [SerializeField] public List<AudioClip> laugh;
    [SerializeField] public List<AudioClip> playful;
    [SerializeField] public List<AudioClip> relieved;
    [SerializeField] public List<AudioClip> sad;
    [SerializeField] public List<AudioClip> surprised;
    
    public AudioClip PlayAudioClip (string audioType, int givenIndex = -1)
    {

        switch (audioType) {
            case "complaints_short":
                return this.PlayClip(this.complaints_short, givenIndex);
                break;
                
            case "complaints_long":
                return this.PlayClip(this.complaints_long, givenIndex);
                break;

            case "grunt":
                return this.PlayClip(this.grunt, givenIndex);
                break;

            case "happy":
                return this.PlayClip(this.happy, givenIndex);
                break;

            case "laugh":
                return this.PlayClip(this.laugh, givenIndex);
                break;

            case "playful":
                return this.PlayClip(this.playful, givenIndex);
                break;

            case "relieved":
                return this.PlayClip(this.relieved, givenIndex);
                break;
            
            case "sad":
                return this.PlayClip(this.sad, givenIndex);
                break;

            case "surprised":
                return this.PlayClip(this.surprised, givenIndex);
                break;
            default:
                return null;
        }
    }
}
