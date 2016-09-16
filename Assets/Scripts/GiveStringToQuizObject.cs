using UnityEngine;
using System.Collections;

public class GiveStringToQuizObject : MonoBehaviour {

	[SerializeField]
	private string myAnswer;

	[SerializeField]
	private QuizObject quizObject;

	void OnEnable()
	{
		if (quizObject != null) 
		{
			quizObject.AnswerString = myAnswer;
			quizObject.QuizCorrectCheck ();
		}

	}
}
