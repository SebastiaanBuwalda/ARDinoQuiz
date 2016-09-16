using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class QuizObject : MonoBehaviour {

	[SerializeField]
	private AudioSource mySource;

	[SerializeField]
	private AudioClip Correct;

	[SerializeField]
	private AudioClip InCorrect;

	[SerializeField]
	private List<string> questionList;
	[SerializeField]
	private List<string> answerList;
	[SerializeField]
	private int maxQuestionNumber = 2;
	private int currentQuestionNumber = 0;
	[SerializeField]
	private Text quizText;

	private string answerString;


	void OnEnable()
	{
		currentQuestionNumber = 0;
		quizText.text = questionList [currentQuestionNumber];
	}

	public void UpdateQuestion()
	{
		currentQuestionNumber++;
		quizText.text = questionList [currentQuestionNumber];
	}

	public void QuizCorrectCheck()
	{
		if (answerString == answerList [currentQuestionNumber]) {
			UpdateQuestion ();
			print ("CORRECT");
			mySource.PlayOneShot (Correct);
			AnswerString = null;
		} else if(answerString!=null)
		{
			mySource.PlayOneShot (InCorrect);
		}
	}

	public string AnswerString
	{
		set
		{
			answerString = value;
		}
	}


}
