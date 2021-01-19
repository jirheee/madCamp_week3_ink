using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageToMain : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        int current = Main.currentStage;
        Main.clearStage = current;
        SceneManager.LoadScene("MainScene");
    }
}
