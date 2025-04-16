using UnityEngine;

public class slime : MonoBehaviour
{
    private int life;
    public int Life => life;
    private int fusion;
    public int Fusion => fusion;


    public slime(int _life) {
        this.life = _life;
    }

    public static slime operator +(slime a, slime b) {
        slime fusion= new slime(a.life + b.life);
       
        return fusion;
    }
}
