using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
	public static DataManager Singleton;
    // Start is called before the first frame update
    void Awake()
    {
		Singleton = this;
    }

    public void SetName(string val)
	{
		PlayerPrefs.SetString("CurrentPlayer", val);
		PlayerPrefs.SetString("RecentPlayer", val);
	}

	public string GetName()
	{
		return PlayerPrefs.GetString("CurrentPlayer");
	}

	public  string GetRecentName()
	{
		return PlayerPrefs.GetString("RecentPlayer");
	}

	public  bool HasRecentName()
	{
		return PlayerPrefs.HasKey("RecentPlayer");
	}

	public  void SetHighScore(int score)
	{
		PlayerPrefs.SetInt("Highscore", score);
		PlayerPrefs.SetString("Topper", PlayerPrefs.GetString("CurrentPlayer"));
	}

}
