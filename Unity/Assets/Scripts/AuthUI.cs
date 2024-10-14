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
        statusText.text = "ȸ������ ��....";
        yield return StartCoroutine(authManager.Register(usernameInput.text, passwordInput.text));
        statusText.text = "ȸ������ ����. �α��� ���ּ���";
    }
    
}
