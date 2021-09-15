using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    int scenenum;

    private void Start()
    {
        scenenum = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //シーン番号が最大だったら０に
            if (scenenum == 2)
            {
                SceneManager.LoadScene(0);
            }
            SceneManager.LoadScene(scenenum+=1);
        }
        else if (Input.GetButtonDown("Fire3"))
        {
            if (scenenum == 2)
            {
                SceneManager.LoadScene(0);
            }
            SceneManager.LoadScene(scenenum += 1);
        }
    }

    //タイトルへ戻る
    public void MoveToTitle()
    {
        SceneManager.LoadScene(0);
    }
    //指定したシーンへ移行
    public void MovetoScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    //指定したシーンへ移行
    public void MovetoScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
