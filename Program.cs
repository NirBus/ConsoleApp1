string txt = "lutfiyar";
for (int i = 0; i < txt.Length; i++)
{
    if (txt[i] == 'a')
    {
        Console.WriteLine("a var");
        break;
    }
    else if (i==txt.Length -1)
    {
        Console.WriteLine("a yoxdur");
    }
 
  
}


