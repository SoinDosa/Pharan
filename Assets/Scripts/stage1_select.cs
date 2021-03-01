using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage1_select : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("1_3_Stage_Map");
    }
}