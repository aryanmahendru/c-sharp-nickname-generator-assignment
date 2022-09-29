#nullable disable

var nickname = new List<string>{ "Doodle","Goober","Goofy","Hobbit","Hotshot"};





Console.WriteLine("Please enter your first name");
     string fname = Console.ReadLine();
Console.WriteLine("Please enter your second name");
     string lname = Console.ReadLine();


bool loop=true;
while (loop){
    Console.WriteLine("1.Change Name");
    Console.WriteLine("2.Display a Random Nickname");
    Console.WriteLine("3.Display All Nicknames");
    Console.WriteLine("4.Add a Nickname");
    Console.WriteLine("5.Remove a Nickname");
    Console.WriteLine("6.Exit");
    string selection = Console.ReadLine();

     if (selection == "1")
     {
    Console.WriteLine("CHANGE NAME");
    Console.WriteLine("Please enter your first name");
        fname = Console.ReadLine();
    Console.WriteLine("Please enter your second name");
        lname = Console.ReadLine();
    Console.WriteLine("Current name is " + fname + " "+ lname);
     }
    
    
    
    else if (selection == "2")
    {
    var random = new Random();
    int index = random.Next(nickname.Count);
    Console.WriteLine("RANDOM NICKNAME");
    Console.WriteLine(fname +" " +nickname[index] + " "+ lname);

    }
    
    else if (selection == "3")
    {
     Console.WriteLine("ALL NICKNAMES");
     for(int d =0;d<nickname.Count ; d++)
     Console.WriteLine(fname + " "+nickname[d]+" "+lname);

    }

    else if (selection == "4")
    {
     int index1 = 0;
     Console.WriteLine("ADD A NICKNAME");
     Console.WriteLine("Please enter a nickname to add:");
     string addingname = Console.ReadLine();
         if(nickname.Contains(addingname))
         {
         index1=-1;
         Console.WriteLine(addingname +"  is already in the nickname list.");
         }
         else if (index1 == 0)
         {
         nickname.Add(addingname);
         Console.WriteLine(addingname + " added to the nickname list.");
         }     
        
    }

    else if (selection == "5")
    {
    int index2 =0; 
    Console.WriteLine("REMOVE A NICKNAME");
    Console.WriteLine("Please enter a nickname to remove:");
    string removingname =Console.ReadLine();
        if(nickname.Contains(removingname))
        {
        index2=-1;
        nickname.Remove(removingname);
        Console.WriteLine(removingname + " removed from the nickname list.");

        }
        else if (index2== 0)
        {
        Console.WriteLine(removingname + " was not found in the nickname list.");  

        }
    }
    else if (selection == "6")
    {
     loop=false;
     Console.WriteLine("Bye");
    }


    


}