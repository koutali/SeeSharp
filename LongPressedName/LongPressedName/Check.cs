namespace LongPressedName
{
    public class Check
    {
        public static bool IsLongPressedName(string name, string typed)
        {
           if(string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(typed))
               return false;

           if (string.IsNullOrEmpty(typed) && !string.IsNullOrEmpty(name))
               return false;

           if (name.Length == 1 && typed.Length == 1)
           {
               return name[0] == typed[0];
           }

           var nameIndex = name.Length - 1;
           var typedIndex = typed.Length - 1;

           while (nameIndex >= 0 && typedIndex >= 0)
           {
               if (name[nameIndex] == typed[typedIndex])
               {
                   nameIndex--;
                   typedIndex--;
                   continue;
               }

               if (nameIndex >= name.Length - 1 || typed[typedIndex] != name[nameIndex + 1])
                   return false;

               typedIndex--;
           }

           return nameIndex == -1 && typedIndex <= 0;
        }
    }
}