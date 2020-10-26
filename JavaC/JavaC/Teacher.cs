using System;
namespace JavaC
{
    public class Teacher : Person, Talkable
    {
    private int age;

    public Teacher(int age, String name)
    {
            this.name = name;
            this.age = age;
    }

    public int getAge()
    {
        return age;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public String talk()
    {
        return "Don't forget to do the assigned reading!";
    }
}

}
