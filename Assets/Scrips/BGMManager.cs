using UnityEngine;

public class BGMManager : MonoBehaviour
{
    private AudioSource bgmSource;

    // 배경 음악을 저장하는 변수
    public AudioClip bgmClip;

    private void Start()
    {
        // 오디오 소스 컴포넌트 가져오기
        bgmSource = GetComponent<AudioSource>();

        // 배경 음악 설정
        bgmSource.clip = bgmClip;

        // 무한반복
        bgmSource.loop = true;

        // 배경 음악 재생
        bgmSource.Play();
    }
}