using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem finishEffect;

    private void OnCollisionEnter2D(Collision2D other)
    {
        finishEffect.Play();
        Invoke("ReloadScene", loadDelay);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
