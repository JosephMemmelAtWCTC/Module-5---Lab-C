namespace TabFlayoutNavigation;

public class MorseHolder
{
    private string doneText = "";
    private string waitingText = "";

    public string addMorse(char newChar){

        if(newChar == ' '){
            doneText += Morse.MorseCoder(waitingText);
            waitingText = "";
        }else{
            waitingText = String.Concat(waitingText, newChar);
        }

        return $"{doneText}{waitingText}_";
        // string rawDone = doneText + waitingText;
        // if(rawDone.EndsWith(' ')){
        //     rawDone = rawDone.Substring(0,rawDone.Length-1)+"_";
        // }
        // return rawDone;
    }

}