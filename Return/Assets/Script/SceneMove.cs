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
            //�V�[���ԍ����ő傾������O��
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

    //�^�C�g���֖߂�
    public void MoveToTitle()
    {
        SceneManager.LoadScene(0);
    }
    //�w�肵���V�[���ֈڍs
    public void MovetoScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    //�w�肵���V�[���ֈڍs
    public void MovetoScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
