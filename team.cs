using System;
enum typeOfTeam {basic, electric, plumber, builder};
public class team
{
    protected int walkSpeed;
    public bool haveCar;
    protected int time_to_fix;
    protected typeOfTeam type;
	public team()
	{
        walkSpeed = 3;
	}

}
