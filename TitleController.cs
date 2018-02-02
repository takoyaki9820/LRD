using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {
	[SerializeField, Header("人数選択の親オブジェクト")]
	private GameObject parent;
    [SerializeField, Header("非表示にするもの")]
    private GameObject startbuttom;
	[SerializeField, Header("二人のボタン")]
	private Button two;
	[SerializeField, Header("三人のボタン")]
	private Button three;
	[SerializeField, Header("四人のボタン")]
	private Button four;
	[SerializeField, Header("二人の時のカメラサイズ")]
	private Vector2 twoCamSize;
	[SerializeField, Header("二人の時のカメラポジション")]
	private List<Vector2> twoCamPos = new List<Vector2>();
	[SerializeField, Header("三人の時のカメラサイズ")]
	private Vector2 threeCamSize;
	[SerializeField, Header("三人の時のカメラポジション")]
	private List<Vector2> threeCamPos = new List<Vector2>();
	[SerializeField, Header("四人の時のカメラサイズ")]
	private Vector2 fourCamSize;
	[SerializeField, Header("四人の時のカメラポジション")]
	private List<Vector2> fourCamPos = new List<Vector2>();
	private Button startButton;
	// Use this for initialization
	void Start () {
		startButton = GameObject.Find("StartButton").GetComponent<Button>();
		startButton.onClick.AddListener(StartButtonDown);
		startButton.Select();
		two.onClick.AddListener(SelectTwo);
		three.onClick.AddListener(SelectThree);
		four.onClick.AddListener(SelectFour);
	}

	public void StartButtonDown() {
		parent.SetActive(true);
        startbuttom.SetActive(false);
		two.Select();
	}

	public void SelectTwo() {
		SOSingleton.Instance.pNum = 2;
		//SOSingleton.Instance.cpNum = 2;
		SOSingleton.Instance.cameraSize = twoCamSize;
		SOSingleton.Instance.cameraPos = new List<Vector2>(twoCamPos);
		gameObject.SetActive(true);
		SceneManager.LoadScene(1);
	}

	public void SelectThree() {
		SOSingleton.Instance.pNum = 3;
		//SOSingleton.Instance.cpNum = 3;
		SOSingleton.Instance.cameraSize = threeCamSize;
		SOSingleton.Instance.cameraPos = new List<Vector2>(threeCamPos);
		SceneManager.LoadScene(2);
	}

	public void SelectFour() {
		SOSingleton.Instance.pNum = 4;
		//SOSingleton.Instance.cpNum = 4;
		SOSingleton.Instance.cameraSize = fourCamSize;
		SOSingleton.Instance.cameraPos = new List<Vector2>(fourCamPos);
		SceneManager.LoadScene(3);
	}
}
