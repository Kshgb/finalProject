using System;

public class House:Building
{
    protected int num_of_flats;


	public House()
	{
        num_of_flats = Random(10, 30);

	}
}
