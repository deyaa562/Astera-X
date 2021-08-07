using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {

	private static int		_Score;

	[SerializeField]
	static Text				_ScoreText;

	// Use this for initialization
	void Start () 
	{
		_Score = 0;
	}
	

	/// <summary>
	/// <para>Accesses the AsteroidsScriptableObject in the AsteraX.c# and gets
	/// the score that should be added according to the size of the destroyed asteroid.</para>
	/// </summary>
	/// <param name="size">Asteroid size</param>
	public static void AddScore(int size)
    {
		_Score = _Score + AsteraX.AsteroidsSO.pointsForAsteroidSize[size];
		//_ScoreText.text = _Score.ToString();
		Debug.Log("Score is:" + _Score.ToString());
    }
}
