using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FadeScenes : MonoBehaviour
{
    public int index;

    public Image blackScreen;
    public Animator fadeAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Fading());
        }
    }

    public void ChangeScene()
    {
        StartCoroutine(Fading());
    }

    IEnumerator Fading()
    {
        fadeAnim.SetBool("Fade", true);
        yield return new WaitUntil(() => blackScreen.color.a == 1);
        SceneManager.LoadScene(index);
    }


}
