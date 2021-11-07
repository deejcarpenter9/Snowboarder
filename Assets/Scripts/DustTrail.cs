using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DustTrail : MonoBehaviour 
{
    [SerializeField] ParticleSystem dustTrail;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            dustTrail.Play();
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            dustTrail.Stop();
        }
    }
}