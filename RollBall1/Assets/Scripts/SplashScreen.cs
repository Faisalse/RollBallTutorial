using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public static int ScreenNumber;
    // Start is called before the first frame update
    void Start()
    {
        if(ScreenNumber == 0)
        {
            StartCoroutine(toSplash());
        }
    }

    // Update is called once per frame
    IEnumerator toSplash()
    {
        yield return new WaitForSeconds(5);
        ScreenNumber = 1;
        SceneManager.LoadScene(ScreenNumber);

    }
}
