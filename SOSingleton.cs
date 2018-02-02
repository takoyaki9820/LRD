using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[CreateAssetMenu(menuName = "Create SOSingleton")]
public class SOSingleton : ScriptableObject {
	private const string PATH = "SOSingleton";
	private static SOSingleton instance;
	public static SOSingleton Instance {
		get {
			if(instance == null) {
				instance = Resources.Load<SOSingleton>(PATH);
			}
			return instance;
		}
	}
	private int _pNum;
	public int pNum {
		get { return _pNum; }
		set { _pNum = value; }
	}
	private Vector2 _cameraSize;
	public Vector2 cameraSize {
		get { return _cameraSize; }
		set { _cameraSize = value; }
	}
	private List<Vector2> _cameraPos = new List<Vector2>();
    internal int pRank;

    public List<Vector2> cameraPos {
		get { return _cameraPos; }
		set { _cameraPos = value; }
	}
	//#if UNITY_EDITOR || UNITY_STANDALONE
	//static void CreateSOSingleton() {
	//	var ston = CreateInstance<SOSingleton>();
	//	AssetDatabase.CreateAsset(ston, "Assets/Resources/SOSingleton.asset");
	//	AssetDatabase.Refresh();
	//}
	//#endif
}
