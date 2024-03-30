using UnityEngine;
using UnityEngine.UI;

public class Aimer : MonoBehaviour
{
    [SerializeField] Camera cam;
    int currentScore = 0;

    UIManager UIman;
    Timer timer;
    SoundManager soundManager;

    void Start()
    {
        UIman = GameObject.FindGameObjectWithTag("GameUI").GetComponent<UIManager>();
        timer = GameObject.FindGameObjectWithTag("GameUI").GetComponent<Timer>();
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }


    void Update()
    {
        if (timer.isTimer)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    Target target = hit.collider.gameObject.GetComponent<Target>();

                    if (target != null)
                    {
                        target.Hit();
                        HitTarget();
                        soundManager.hitSound();
                    }
                }
                else
                {
                    MissTarget();
                    soundManager.missSound();
                }
            }
        }
        else
        {
            UIman.UpdateResults(currentScore);
        }
    }

    void HitTarget()
    {
        currentScore += 3;
        UIman.UpdateScore(currentScore);
    }

    void MissTarget()
    {
        currentScore -= 1;
        UIman.UpdateScore(currentScore);
    }
}
