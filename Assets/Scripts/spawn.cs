using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.ImageEffects;

public class spawn : MonoBehaviour
{
    public GameObject apparition;
    public Camera player;
    public AudioClip sound;
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        apparition.SetActive(false);
        source = GetComponent<AudioSource>();
        //player = Camera.main;
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        source.clip = sound;
        source.Play();

        apparition.SetActive(true);

        enableScreenEffect(true);
        yield return new WaitForSeconds(6);
        enableScreenEffect(false);
        apparition.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {

    }
    void enableScreenEffect(bool value)
    {
        player.GetComponent<BlurOptimized>().enabled = value;
        player.GetComponent<NoiseAndScratches>().enabled = value;
    }
}
