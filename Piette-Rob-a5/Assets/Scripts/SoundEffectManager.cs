using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
   [SerializeField] private AudioSource _audioSource;

    void Update() 
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}