using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word : MonoBehaviour
{
    /// <summary>
    /// Слово отображено
    /// </summary>
    public void OnWordEnter()
    {
        if (GamePlay.Single.State == GamePlayState.BeginShowAnswers)
            Words.Single.NotifyWordEnter();
    }

    /// <summary>
    /// Слово скрыто
    /// </summary>
    public void OnWordLeave()
    {
        if (GamePlay.Single.State == GamePlayState.BeginShowQuestionResultAnimation)
            Words.Single.NotifyWordLeave();
    }
}
