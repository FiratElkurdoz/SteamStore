using System;

public class DLC
{
    public string name;
    public float price;
    Game game;

	public DLC(string n, float p, Game g)
	{
        name = n;
        price = p;
        game = g;
	}
}
