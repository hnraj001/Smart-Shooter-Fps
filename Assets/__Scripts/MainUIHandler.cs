using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
	//Public fields
	public GameObject startPanel;
	public Image mapPreview;

	public Sprite factoryImage;
	public Sprite outpostImage;
	public Sprite traditionalImage;
	public Sprite randomImage;

	public Text mapNameText;


	public Text screenNameText;
	public InputField screenInput;

	public GameObject mapPanel;

	//private fields
	string map;

	/* Game Events */
	void Start()
	{
		map = "random";

		if(DataManager.Singleton.HasRecentName())
			screenInput.text = DataManager.Singleton.GetRecentName();

	}

	/*Button Event Handlers */
	public void SelectMapClick()
	{
		mapPanel.SetActive(true);
		startPanel.SetActive(false);
	}


	public void FactoryMapClick()
	{
		BackToStartPanel();
		map = "factory";
		mapPreview.sprite = factoryImage;
		mapNameText.text = "Factory";
	}
	public void OutpostMapClick()
	{
		BackToStartPanel();
		map = "outpost";
		mapPreview.sprite = outpostImage;
		mapNameText.text = "Outpost";
	}
	public void TraditionalMapClick()
	{
		BackToStartPanel();
		map = "traditional";
		mapPreview.sprite = traditionalImage;
		mapNameText.text = "Traditional";

	}
	public void RandomMapClick()
	{
		BackToStartPanel();
		map = "random";
		mapPreview.sprite = randomImage;
		mapNameText.text = "RANDOM";
	}
	
	public void PlayClick()
	{
		string pname;

		if (screenNameText.text != "")
			pname = screenNameText.text;
		else
			pname = "_DefaultUser";

		DataManager.Singleton.SetName(pname);

		if(map!="random")
			SceneManager.LoadScene(map);
		else
			SceneManager.LoadScene(Random.Range(1, 4));

	}

	void BackToStartPanel()
	{
		mapPanel.SetActive(false);
		startPanel.SetActive(true);
	}
}
