using UnityEngine;

public class gamemanager : MonoBehaviour
{
    private Inventory inventary = new Inventory();
    private slime slime1 = new slime(20);
    private slime slime2 = new slime(14);
    void Start()
    {

        Item item1 = new("globos");
        Item item2 = new("armor", TypeOfItem.Armor);
        Item item3 = new("potion", TypeOfItem.Consumable);
        Item item4 = new("bread", TypeOfItem.Consumable);
        Item item5 = new("sword", TypeOfItem.Enchansment);

        inventary.Add(item1);
        inventary.Add(item1, 1);

        inventary.Add(item2);
        inventary.Add(item3, 5);
        inventary.Add(item4, 15);
        inventary.Add(item5, 41);

        inventary.ShowAllItems();

        int slime3 = slime1.Life + slime2.Life;
        print("Se a creado un slime convinado " + slime1.Life + " con el slime " + slime2.Life + " y se creo un slime con " + slime3 + "  de vida ");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
