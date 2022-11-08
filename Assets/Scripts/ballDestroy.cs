using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ballDestroy : MonoBehaviour
{
    public bool blueRing, greenRing, redRing;

    public AudioClip rightTarget;
    public AudioClip wrongTarget;

    public static int score;

    public static int throws = 0;

    
    private void Start()
    {
        CanvasManager.Instance.UpdateScore(score);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (throwingZone.onZone == 1)
        {
            if (other.tag == "Throwable" && other.GetComponent<sphereScript>().blueSphere)
            {
                if (blueRing == true)
                {
                    Destroy(other.gameObject);
                    ballSpawnController.bBall -= 1;
                    CanvasManager.Instance.UpdateScore(score += 4);
                    AudioSource.PlayClipAtPoint(rightTarget, transform.position, 1f);
                    
                }
                else
                {
                    Destroy(other.gameObject);
                    ballSpawnController.bBall -= 1;
                    AudioSource.PlayClipAtPoint(wrongTarget, transform.position, 1f);
                }
                CanvasManager.Instance.UpdateThrows(throws += 1);
            }

            if (other.tag == "Throwable" && other.GetComponent<sphereScript>().redSphere)
            {
                if (redRing == true)
                {
                    Destroy(other.gameObject);
                    ballSpawnController.rBall -= 1;
                    CanvasManager.Instance.UpdateScore(score = score * score);
                    AudioSource.PlayClipAtPoint(rightTarget, transform.position, 1f);
                }
                else
                {
                    Destroy(other.gameObject);
                    ballSpawnController.rBall -= 1;
                    AudioSource.PlayClipAtPoint(wrongTarget, transform.position, 1f);
                }
                CanvasManager.Instance.UpdateThrows(throws += 1);
            }

            if (other.tag == "Throwable" && other.GetComponent<sphereScript>().greenSphere)
            {
                if (greenRing == true)
                {
                    Destroy(other.gameObject);
                    ballSpawnController.gBall -= 1;

                    CanvasManager.Instance.UpdateScore(score = score - 3);
                    AudioSource.PlayClipAtPoint(rightTarget, transform.position, 1f);
                }
                else
                {
                    Destroy(other.gameObject);
                    ballSpawnController.gBall -= 1;
                    AudioSource.PlayClipAtPoint(wrongTarget, transform.position, 1f);
                }
                CanvasManager.Instance.UpdateThrows(throws += 1);
            }
            if (other.tag == "Throwable" && other.GetComponent<sphereScript>().whiteSphere)
            {

                Destroy(other.gameObject);
                AudioSource.PlayClipAtPoint(wrongTarget, transform.position, 1f);
                CanvasManager.Instance.UpdateScore(score = 0);
                CanvasManager.Instance.UpdateThrows(throws = 0);
                ballSpawnController.wBall -= 1;


            }
        }
        else
        {
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(wrongTarget, transform.position, 1f);
            ballSpawnController.wBall -= 1;
            ballSpawnController.rBall -= 1;
            ballSpawnController.bBall -= 1;
            ballSpawnController.gBall -= 1;
        }
        
    }

    private void Update()
    {
        if(score > 25)
        {
            CanvasManager.Instance.UpdateScore(score = 0);
            CanvasManager.Instance.UpdateThrows(throws = 0);
        }

        if(throws == 5 && score != 25)
        {
            CanvasManager.Instance.UpdateScore(score = 0);
            CanvasManager.Instance.UpdateThrows(throws = 0);
        }
    }
}
