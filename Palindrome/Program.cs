var str = "hadeifiedh";
//         hdeifiedah

var stack = new Stack<string>();

var left = "";
var right = "";
var len = 0;
var strleft = "";
var strright = "";

for (int i = 0; i+2< str.Length; i++)
{    
   left = str.Substring(i,1);
    right = str.Substring(i+2, 1);

    if (left.Equals(right))
    {
         len = i+1;       
        
        for (int j = 0, k = len; j < len&& k>0; j++,k--)
        {
            if(len + j + 1< str.Length) 
            {                
                left = str.Substring(k-1, 1); 
                right = str.Substring(len+j+1, 1);                

                if (!left.Equals(right))
                {
                    break;
                }
                stack.Push(left);
                strleft += left;
                strright += right;
            }
        }       
    }
}
var reversedleft = "";
var stlen = stack.Count;
for (int i = 0; i < stlen; i++)
{
    reversedleft +=stack.Pop();
}

Console.WriteLine($"palindrome {reversedleft+str[len]+strright}");







