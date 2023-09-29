namespace MethodsExercise
{
    public class Program
    {


        static void Main(string[] args)

        {

            int Addition = Add(5, 10);
            int Subtraction = Subtract(10, 5);
            int Division = Divide(10, 5);
            int Multiplicaiton = Multiply(10, 5);

            Console.WriteLine(Addition);
            Console.WriteLine(Subtraction);
            Console.WriteLine(Division);
            Console.WriteLine(Multiplicaiton);

            MadLib();

        }

        public static void MadLib()
        {
            Console.WriteLine("What\'s your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What\'s your least favorite food?");
            string food = Console.ReadLine();

            Console.WriteLine("What\'s your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Well we need a name for your pet sooooo What\'s your pet\'s name?");
            string petName = Console.ReadLine();

            Console.WriteLine("Pick a day of the week");
            string day = Console.ReadLine();

            Console.WriteLine("What\'s your least favorite color?");
            string color = Console.ReadLine();



            Console.Write($"Hey {name}!  My name\'s Buzz amd I\'m a housefly.  I know...  My parents weren\'t very original but if you don\'t like my name, well, you can just go suck an egg.  Most people call me gramps \'cause I\'m 42 days old.  Houseflies are lucky to make it 30 days.  We have short lifespans already, and then there's you jerky humans that always like to swat us flatter than a booger run over by a freight train.  You and I are going to play a mad lib today.  We\'ll keep it short since I don\'t have years to waste like you.  Here we gooooo!  One {day} afternoon, a young person, {name}, and their pet {animal}, {petName}, went for a hike in the woods.  I and my grandson just so happened to be enjoying our favorite snack, horse poo, and we saw {name} and {petName} come up to a creek crossing.  The bridge had fallen so {name} picked {petName} up and decided to walk across a downed tree nearby.  It was a narrow tree and... Wow!  What a great balancing act.  {name} was even suck\'n down some {food} with one hand and holding {petName} with the other.  Since these pesky humans killed most of my kin I decided my grandson and I would cause a li\'l ruckus.  We buzzed and buzzed and buzzed {name} and they began swaying back \'n forth.  {name} started swatting at me with their {food} and eventually lost their footing.   It was so funny... {petName} somehow landed on the tree and {name} landed feet first in the creek. The creek is only a few feet deep but the muddy bottom is like quicksand.  {name} looked like a weeble wobble stuck in the mud and {petName} looked so confused.  My grandson and I laughed so hard I lost all of my delicious horse poo but it was ok.  Tastes better the second time anywho right?  Out of nowhere, a big, {color}, griffin swooped in, swallowed {name} whole, and poor {petName} was left all alone.  Serves {name} right! (Dang fly killers them humans are!) Now I know what you\'re thinking. That was a gross and sad story.  I reckon so but there's a lesson here.  You humans should learn to value your time like us flies.  You waste so much time just \'cause you think you can.  You never know when you might end up at the bottom of a griffin\'s gut so you better get\'er done.  You should also treat us flies with some respect \'cause karma can be a real #$##$.  That\'s about all the time I have for now.  I  have people to pester.");

        }

        public static int Add(int num1, int num2)
        { 
            return num1 + num2; 
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }

}
