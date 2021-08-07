using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class JumpsGT : MonoBehaviour 
{
	private static PlayerShip	_Player;

	private static int			_Jumps;
	[Header("Assign in the inspector")]
	public static Text			_JumpsText;

	private void Awake()
    {
		_Player = null;
		_Jumps = 3;
		_JumpsText.text = _Jumps.ToString();
    }


	/// <summary>
	/// <para>Decreases the number of jumps remaining and moves the playership to a safe zone.</para>
	/// <para>If there are no more jumps remaining the scene will be reloaded after 4 seconds </para>
	/// </summary>
	/// <param name="player">PlayerShip</param>
	public static void Jump(GameObject player)
    {
		if(_Jumps > 0)
        {
			if(_Player == null)
            {
                try
                {
					_Player = player.GetComponent<PlayerShip>();
                } 
				catch(NullReferenceException e)
                {
					Debug.LogWarning(e);
                }
            }

			_Jumps--;
			_JumpsText.text = _Jumps.ToString();
			_Player.Move2SafeZone();
        }
        else
        {
			
			ReloadScene();
        }
    }

	private static void ReloadScene()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	


	
}
