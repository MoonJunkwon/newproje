using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    public Text characterNameText;

    private void Start()
    {
        // PlayerPrefs에서 캐릭터 이름을 가져와서 텍스트로 표시합니다.
        string characterName = PlayerPrefs.GetString("CharacterName");
        characterNameText.text = characterName;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Debug.Log("Player found: " + player.name);
            characterNameText.transform.parent = player.transform;
            characterNameText.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        else
        {
            Debug.LogWarning("Player not found.");
        }
    }
}
