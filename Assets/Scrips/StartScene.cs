using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public InputField characterNameInput;

    // 이 버튼에 연결된 함수를 호출합니다.
    public void StartGame()
    {
        string characterName = characterNameInput.text;

        // 이름이 비어있지 않다면 MainScene으로 이동합니다.
        if (!string.IsNullOrEmpty(characterName))
        {
            // 캐릭터 이름을 다음 씬으로 전달합니다.
            PlayerPrefs.SetString("CharacterName", characterName);
            SceneManager.LoadScene("MainScene");
        }
    }
}