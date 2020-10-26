using System;
namespace JavaC
{
    public class Dog : Pet, Talkable
    {
    private boolean friendly;

    public Dog(boolean friendly, String name)
    {
            this.name = name;
            this.friendly = friendly;
    }

    public boolean isFriendly()
    {
        return friendly;
    }

    public String talk()
    {
        return "Bark";
    }

    public String toString()
    {
        return "Dog: " + "name=" + name + " friendly=" + friendly;
    }


}
}
