using System;

public class JEU
{
    protected int num_of_teams;
    protected int num_of_cars;
    public bool team_needed;
    protected bool teams_available;
    protected bool cars_available;
	public JEU()
	{
        num_of_cars = Convert.ToInt32(carsnum.Text);
        num_of_teams = Convert.ToInt32(teamsnum.Text);
        team_needed = false;
        if (num_of_fixers > 0)
            teams_available = true;
        //else output "num of fixers must me more than 0";

        if (num_of_cars > 0)
            cars_available = true;    
        
	}
    public void ALARM(Buildings.buildingID,)
    {

    }
}
