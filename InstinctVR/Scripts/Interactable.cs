using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{

    public float radius = 3f;
    public Transform interactionTransform;

    Material m_Material;

    const float AnimationSmoothTime = 0.1f;

    float animate = 1;
    bool isFocus = false;
	bool hasInteracted = false;

    Transform player;
    Animator animator;
    Animation anim;

    GameObject _orb1;
    GameObject _orb2;
    GameObject _orb3;
    GameObject _orb4;
    GameObject _orb5;
    GameObject _orb6;
    GameObject _orb7;
    GameObject _portal;

	GameObject Player;

    GameObject musicPlayer;

	GameObject OrbClickSound;

    private void Start()
    {
        RenderSettings.ambientLight = Color.red;
        RenderSettings.ambientGroundColor = Color.red;

        _orb1 = GameObject.Find("OrbOne");
        _orb2 = GameObject.Find("OrbTwo");
        _orb3 = GameObject.Find("OrbThree");
        _orb4 = GameObject.Find("OrbFour");
        _orb5 = GameObject.Find("OrbFive");
        _orb6 = GameObject.Find("OrbSix");
        _orb7 = GameObject.Find("OrbSeven");
        _portal = GameObject.Find("Portal");

		Player = GameObject.Find ("Player");

        musicPlayer = GameObject.Find("musicPlayer");

		OrbClickSound = GameObject.Find ("OrbClickSound");

        animator = GetComponentInChildren<Animator>();

        m_Material = GetComponent<Renderer>().material;

        _orb1.GetComponent<MeshRenderer>().enabled = true;
        _orb2.GetComponent<MeshRenderer>().enabled = false;
        _orb3.GetComponent<MeshRenderer>().enabled = false;
        _orb4.GetComponent<MeshRenderer>().enabled = false;
        _orb5.GetComponent<MeshRenderer>().enabled = false;
		_orb6.GetComponent<MeshRenderer>().enabled = false;
        _orb7.GetComponent<MeshRenderer>().enabled = false;
        _portal.GetComponent<MeshRenderer>().enabled = false;

    }

    public virtual void OrbOne ()
    {
        Debug.Log("Interacting with " + transform.name);
        Debug.Log("Something is happening...");
		OrbClickSound.GetComponent<AudioSource>().Play();
        animator.SetFloat(transform.name, animate);
		transform.GetComponent<AudioSource>().Play();
        RenderSettings.fogDensity = 0.015f;
        RenderSettings.ambientLight = Color.yellow;
        RenderSettings.ambientGroundColor = Color.yellow;
        _orb1.GetComponent<MeshRenderer>().enabled = false;
        _orb2.GetComponent<MeshRenderer>().enabled = true;
		_orb1.GetComponent<Collider> ().enabled = false;
		_orb2.GetComponent<Collider> ().enabled = true;
    }

    public virtual void OrbTwo()
    {
        Debug.Log("Interacting with " + transform.name);
        Debug.Log("Something is happening...");
		OrbClickSound.GetComponent<AudioSource>().Play();
        animator.SetFloat(transform.name, animate);
        RenderSettings.fogDensity = 0.02f;
        RenderSettings.ambientLight = Color.blue;
        RenderSettings.ambientGroundColor = Color.blue;
        _orb2.GetComponent<MeshRenderer>().enabled = false;
        _orb3.GetComponent<MeshRenderer>().enabled = true;
		_orb2.GetComponent<Collider> ().enabled = false;
		_orb3.GetComponent<Collider> ().enabled = true;
    }

    public virtual void OrbThree()
    {
        Debug.Log("Interacting with " + transform.name);
        Debug.Log("Something is happening...");
		OrbClickSound.GetComponent<AudioSource>().Play();
        animator.SetFloat(transform.name, animate);
        //_orb1.GetComponent<AudioSource>().Pause();
       transform.GetComponent<AudioSource>().Play();
        RenderSettings.fogDensity = 0.025f;
        RenderSettings.ambientLight = Color.green;
        RenderSettings.ambientGroundColor = Color.green;
        _orb3.GetComponent<MeshRenderer>().enabled = false;
       	_orb4.GetComponent<MeshRenderer>().enabled = true;

		_orb3.GetComponent<Collider> ().enabled = false;
		_orb4.GetComponent<Collider> ().enabled = true;
    }

    public virtual void OrbFour()
    {
        Debug.Log("Interacting with " + transform.name);
        Debug.Log("Something is happening...");
		OrbClickSound.GetComponent<AudioSource>().Play();
        animator.SetFloat(transform.name, animate);
        RenderSettings.fogDensity = 0.03f;
        RenderSettings.ambientLight = Color.magenta;
        RenderSettings.ambientGroundColor = Color.magenta;
       _orb4.GetComponent<MeshRenderer>().enabled = false;
       _orb5.GetComponent<MeshRenderer>().enabled = true;

		_orb4.GetComponent<Collider> ().enabled = false;
		_orb5.GetComponent<Collider> ().enabled = true;
    }

    public virtual void OrbFive()
    {
        Debug.Log("Interacting with " + transform.name);
        Debug.Log("Something is happening...");
		OrbClickSound.GetComponent<AudioSource>().Play();
        animator.SetFloat(transform.name, animate);
        transform.GetComponent<AudioSource>().Play();
        RenderSettings.fogDensity = 0.035f;
        RenderSettings.ambientLight = Color.cyan;
        RenderSettings.ambientGroundColor = Color.cyan;
        _orb5.GetComponent<MeshRenderer>().enabled = false;
        _orb6.GetComponent<MeshRenderer>().enabled = true;
		_orb5.GetComponent<Collider> ().enabled = false;
		_orb6.GetComponent<Collider> ().enabled = true;
    }

    public virtual void OrbSix()
    {
        Debug.Log("Interacting with " + transform.name);
        Debug.Log("Something is happening...");
		OrbClickSound.GetComponent<AudioSource>().Play();
        animator.SetFloat(transform.name, animate);
		transform.GetComponent<AudioSource>().Play();
        RenderSettings.fogDensity = 0.04f;
        RenderSettings.ambientLight = Color.yellow;
        RenderSettings.ambientGroundColor = Color.yellow;
        _orb6.GetComponent<MeshRenderer>().enabled = false;
        _orb7.GetComponent<MeshRenderer>().enabled = true;
		_orb6.GetComponent<Collider> ().enabled = false;
		_orb7.GetComponent<Collider> ().enabled = true;

    }

    public virtual void OrbSeven()
    {
        Debug.Log("Interacting with " + transform.name);
        Debug.Log("Something is happening...");
		OrbClickSound.GetComponent<AudioSource>().Play();
        animator.SetFloat(transform.name, animate);
        transform.GetComponent<AudioSource>().Play();
        RenderSettings.fogDensity = 0.045f;
        RenderSettings.ambientLight = Color.black;
        RenderSettings.ambientGroundColor = Color.black;
        _orb7.GetComponent<MeshRenderer>().enabled = false;
        _portal.GetComponent<MeshRenderer>().enabled = true;
		_orb7.GetComponent<Collider> ().enabled = false;
		_portal.GetComponent<Collider> ().enabled = true;

    }

    public virtual void Portal()
    {
        Debug.Log("Interacting with " + transform.name);
        Debug.Log("Something is happening...");
        Debug.Log("Game has been completed");
		OrbClickSound.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if (distance <= radius)
            {
                if (gameObject == _orb1)
                {
                    OrbOne();
                }

                if (gameObject == _orb2)
                {
                    OrbTwo();
                }

                if (gameObject == _orb3)
                {
                    OrbThree();
                }

                if (gameObject == _orb4)
                {
                    OrbFour();
                }

                if (gameObject == _orb5)
                {
                    OrbFive();
                }

                if (gameObject == _orb6)
                {
                    OrbSix();
                }

                if (gameObject == _orb7)
                { 
                OrbSeven();
                }

                if (gameObject == _portal)
                {
                    Portal();
                }
                hasInteracted = true;
            }
        }
    }

    public void OnFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocused ()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}