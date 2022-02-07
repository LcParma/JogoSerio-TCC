using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Cor do cursor ao passar em algo
    public Color m_MouseOverColor;
    private Color m_CurrentCursorColor;
    public Texture DefaultCursor;
    private Texture m_CurrentCursor;
    private bool m_Navegation;
    // Start is called before the first frame update
    void Start()
    {
        m_CurrentCursor = DefaultCursor;
        m_CurrentCursorColor = Color.white;
    }
    void OnGUI()
    {
        Color guiColor = GUI.color;
        GUI.color = m_CurrentCursorColor;
        if (!m_Navegation)
        {
            // Cursor.lockState = CursorLockMode.Confined;
            Cursor.lockState = CursorLockMode.None;
            var pos = Input.mousePosition;
            GUI.DrawTexture(new Rect(pos.x, Screen.height - pos.y, 64f, 64f), m_CurrentCursor);
            // Volta a cor da GUI pro padrão
            GUI.color = guiColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_Navegation = Input.GetButton("Horizontal") || Input.GetButton("Vertical") || Input.GetButton("Turn");
    }
    public void CursorColorChange(bool colorize)
    {
        m_CurrentCursorColor = colorize ? m_MouseOverColor : Color.white;
    }
}
