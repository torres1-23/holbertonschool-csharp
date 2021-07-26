using System;

enum Rating
{
	Good,
	Great,
	Excellent
}

struct Dog
{
    public Dog (string newName, float newAge, string newOwner, Rating newRating)
    {
        name = newName;
        age = newAge;
        owner = newOwner;
        rating = newRating;
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}
