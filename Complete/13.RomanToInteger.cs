public class RomanToInteger {
    public int RomanToInteger(string s) {
        int sum = 0;
        int prevValue = 0;
        foreach(char c in s) {
            int currentValue = 0;
            switch(c.ToString()){               
                case "M":
                    currentValue = 1000;
                    break;
                case "D":
                    currentValue = 500;
                    break;
                case "C":
                    currentValue = 100;
                    break;
                case "L":
                    currentValue = 50;
                    break;
                case "X":
                    currentValue = 10;
                    break;
                case "V":
                    currentValue = 5;
                    break;
                case "I":
                    currentValue = 1;
                    break;
            }
            // if the 
            if(currentValue <= prevValue)
            {
                sum+= currentValue;
            } else { // calc the subtraction
                sum+= (currentValue - (prevValue * 2));
            }
            prevValue = currentValue;
        }
        return sum;
    }
}