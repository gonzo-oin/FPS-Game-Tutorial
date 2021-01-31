using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class AudioManager : MonoBehaviour{

    [SerializeField] protected AudioSource babyAudioSource;
    [SerializeField] protected AudioSource weaponAudioSource;
	private void Awake () {
        // babyAudioSource = this.gameObject.GetComponent<AudioSource>();
	}
    
    protected AudioClip PlayClip (List<AudioClip> clipList, int givenIndex = -1) {
        int clipIndex = -1;
        if(clipList != null && clipList.Count > 0) {
            clipIndex = 0;
            if (givenIndex == -1 && clipList.Count > 1)
            {
                clipIndex = Random.Range(0, clipList.Count);
            } // /!\ max range is exclusive
            else if (givenIndex != -1)
            {
                clipIndex = givenIndex;
            }
            return clipList[clipIndex];
		}

        return null;
    }
}
