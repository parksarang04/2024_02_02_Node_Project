using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AuthUI : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;

    public Button registerButton;

    public Text statusText;

    private AuthManager authManager;
    // Start is called before the first frame update
    void Start()
    {
        authManager = GetComponent<AuthManager>();
        registerButton.onClick.AddListener(OnRegisterClick);
    }
    private void OnRegisterClick()
    {
        StartCoroutine(RegisterCorouitine());
    }
    private IEnumerator RegisterCorouitine()
    {
        statusText.text = "회원가입 중....";
        yield return StartCoroutine(authManager.Register(usernameInput.text, passwordInput.text));
        statusText.text = "회원가입 성공. 로그인 해주세요";
    }
    
}
