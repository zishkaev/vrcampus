using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {
	public LevelScene scene;
	public bool loadAtStart;

	private void Start() {
		if (loadAtStart)
			Load();
	}

	public void Load() {
		SceneManager.LoadScene((int)scene);
	}
}

public enum LevelScene {
	Hub = 1,
	Loc1 = 2,
	Loc2 = 3,
	Loc3 = 4
}
