using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashParticle.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene ()
    {
        SceneManager.LoadScene(0);
    }
}