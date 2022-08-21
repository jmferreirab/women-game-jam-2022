using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerSounds : MonoBehaviour
{

    [SerializeField] AudioClip[] penguinChirps;
    [SerializeField] int chirpDelayLow = 3;
    [SerializeField] int chirpDelayHigh = 3;
    private AudioSource audioSource;
    private int _delay = 0;
    private int _sound_id = 0;
    private int _sound_id_last_played = 0;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(playRandomized());
    }

    private void Update()
    {
        Debug.Log(Random.Range(0, penguinChirps.Length));
    }

    IEnumerator playRandomized()
    {

        audioSource.PlayOneShot(penguinChirps[_sound_id]);

        while (true)
        {
            _delay = Random.Range(chirpDelayLow, chirpDelayHigh);
            // Range for ints in max exclusive. Don't do +=-1.
            _sound_id = Random.Range(0, penguinChirps.Length);

            // Give it one chance to pick up a sound that is not the last used.
            if (_sound_id == _sound_id_last_played)
            {
                _sound_id = Random.Range(0, penguinChirps.Length);                
            }

            _sound_id_last_played = _sound_id;

            yield return new WaitForSeconds(_delay);
            audioSource.PlayOneShot(penguinChirps[_sound_id]);
            // Debug.Log("Chirp chirp. Delay: " + _delay.ToString() + "id: " +_sound_id.ToString());
        }
    }
}
