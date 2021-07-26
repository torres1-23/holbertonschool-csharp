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
    public override string ToString()
    {
        return ($"Dog Name: {this.name}\n" +
                $"Age: {this.age}\n" +
                $"Owner: {this.owner}\n" +
                $"Rating: {this.rating}");
    }  
}
