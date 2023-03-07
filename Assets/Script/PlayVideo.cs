using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public GameObject videoEndingOutput;
    public GantiScene gs;
    private void Start()
    {
        videoEndingOutput.SetActive(false);
    }
    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }

    public void playVideo()
    {
        videoEndingOutput.SetActive(true);
    }

    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }

    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(12.0f);
        gs.ChangeMyScene("Menu");
    }
}
