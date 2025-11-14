using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private GameObject _subject;

    public bool IsEmpty
    {
        get
        {
            if(_subject == null)
                return true;
            
            return false;
        }
    }

    public Vector3 Position => transform.position;

    public void Occupy(GameObject subject)
    {
        _subject = subject;
    }
}
