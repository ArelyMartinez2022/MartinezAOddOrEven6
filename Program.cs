/* See https://aka.ms/new-console-template for more information
ARELY MARTINEZ 

OCT 19 2022 9:19 AM 

ODD OR EVEN #6

THIS PROGRAM WILL ASK THE USER FOR A NUMBER 
ONCE THEY ENTER A VAILD WHOLE NUMEBR THE
PROGRAM WILL DETERMINE IF ITS ODD OR EVEN. IF
ITS NOT A VAILD INPUT IT WILL CONTINUE TO ASK 
THEY USER UNTILL IT VAILD. AT THE END THE PROGRAM 
WILL ASK THE USER TO PLAY AGAIN. IF THEY ENTER "YES"
THE PROGRAM WILL REPLAY. IF THEY ENTER "NO" IT WILL 
END IF THEY ENTER ANY VARIATION THAT ISNT YES OR NO 
THEN IT WILL CONTINUE TO ASK THEM UNTIL THEY DO. 

PEER REVIEW: NAME -- REVIEW
*/
Console.Clear();

bool playAgain = true;
while(playAgain){
    //Console.Clear();
    string userInput;

    bool isConverted = true;
    bool isNumber; 
    long vaildNum = 0;
    Console.WriteLine("LETS PLAY A GAME: ODD OR EVEN ");
    Console.WriteLine(" ");
    
    while (isConverted){
        Console.WriteLine("ENTER A WHOLE NUMBER ");
        userInput = Console.ReadLine();

        isNumber = Int64.TryParse(userInput, out vaildNum);

        if(isNumber == true) {
            isConverted = false;
            Console.WriteLine(" ");
            Console.WriteLine("YOU ENTERED IN A NUMBER ");
            Console.WriteLine(" ");
        } else {
            Console.WriteLine( " " );
            Console.WriteLine("INVAILD ENTRY, TRY AGAIN ");
            Console.WriteLine(" ");
        }
    }

    long answer = (vaildNum % 2);

    if (answer == 0 ){
        Console.WriteLine(vaildNum + " IS EVEN");
        Console.WriteLine(" ");
    }
    if (answer == 1 ){
        Console.WriteLine(vaildNum + " IS ODD");
        Console.WriteLine(" ");
    }
    
    bool converted = true;

    while (converted){
        Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN? YES OR NO? ");
        string rePlay = Console.ReadLine();

        if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" || rePlay == "no"){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
            Console.WriteLine(" ");
        }
    } 
}